using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int k = 2;
            double newtonSymbolValue = NewtonSymbolTask(n, k);
            Console.WriteLine("Newton symbol for Task: {0}", newtonSymbolValue);
            n = 6;
            newtonSymbolValue = NewtonSymbolDelegates(n, k);
            Console.WriteLine("Newton symbol for Delegates: {0}", newtonSymbolValue);
            n = 7;
            newtonSymbolValue = NewtonSymbolAsyncAwait(n, k).Result;
            Console.WriteLine("Newton symbol for Delegates: {0}", newtonSymbolValue);
            Console.Read();
        }
        public static double NewtonSymbolTask(int n, int k)
        {
            Task<double> factorTask = Task.Factory.StartNew(
                (obj) => CalculateFactor(k),
                100);
            Task<double> denominatorTask = Task.Factory.StartNew(
                (obj) => CalculateDenominator(n, k),
                100);
            factorTask.Wait();
            denominatorTask.Wait();


            return denominatorTask.Result / factorTask.Result;
        }

        public static double CalculateFactor(int k)
        {
            double factor = 1;
            for (int i = 1; i <= k; i++)
                factor *= i;
            return factor;
        }
        public static double CalculateDenominator(int n, int k)
        {
            double denominator = 1;
            for (int i = (n - k - 1); i <= n; i++)
                denominator *= i;
            return denominator;
        }

        public static double NewtonSymbolDelegates(int n, int k)
        {
            Func<int, double> funcFactor = CalculateFactor;
            Func<int, int, double> funcDenominator = CalculateDenominator;
            try
            {
                IAsyncResult factor = funcFactor.BeginInvoke(k, null, null);
                IAsyncResult denominator = funcDenominator.BeginInvoke(n, k, null, null);
                while (factor.IsCompleted == false && denominator.IsCompleted == false)
                { }

                return funcDenominator.EndInvoke(denominator) / funcFactor.EndInvoke(factor);
            }
            catch (PlatformNotSupportedException e)
            {
                return CalculateDenominator(n, k) / CalculateFactor(k);
            }
        }

        public static async Task<double> NewtonSymbolAsyncAwait(int n, int k)
        {
            var denominator = Task.Run(() => CalculateDenominator(n, k));
            var factor = Task.Run(() => CalculateFactor(k));

            await Task.WhenAll(denominator, factor);

            return denominator.Result / factor.Result;
        }
    }
}
