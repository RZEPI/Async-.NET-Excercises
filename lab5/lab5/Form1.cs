using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {

        private int numberToCompute = 0;
        private int highestPercentageReached = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, k;
            (n,k)=GetValues();
            if (n!=0)
                taskResult.Text = NewtonSymbolTask(n,k).ToString();

        }

        public (int,int) GetValues()
        {
            int n, k;
            if (!Int32.TryParse(nValue.Text, out n))
            {
                taskResult.Text = "NAN";
                n = 0;
            }
            if (!Int32.TryParse(kValue.Text, out k))
            {
                taskResult.Text = "NAN";
            }
            return (n,k);
        }

        public static double NewtonSymbolTask(int n, int k)
        {

            Task<double> factorTask = System.Threading.Tasks.Task.Factory.StartNew(
                (obj) => CalculateFactor(k),
                100);
            Task<double> denominatorTask = System.Threading.Tasks.Task.Factory.StartNew(
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

        private void Delegates_Click(object sender, EventArgs e)
        {
            int n, k;
            (n, k) = GetValues();
            if (n != 0)
                delegatesResult.Text = NewtonSymbolDelegates(n, k).ToString();
        }

        public static double NewtonSymbolDelegates(int n, int k)
        {
            Func<int, double> funcFactor = CalculateFactor;
            Func<int, int, double> funcDenominator = CalculateDenominator;
            IAsyncResult factor = funcFactor.BeginInvoke(k, null, null);
            IAsyncResult denominator = funcDenominator.BeginInvoke(n, k, null, null);
            while (factor.IsCompleted == false && denominator.IsCompleted == false)
            { }

            return funcDenominator.EndInvoke(denominator) / funcFactor.EndInvoke(factor);
            
        }


        private void Async_Click(object sender, EventArgs e)
        {
            int n, k;
            (n, k) = GetValues();
            if (n != 0)
                asyncResult.Text = NewtonSymbolAsyncAwait(n, k).Result.ToString();
        }
        public static async Task<double> NewtonSymbolAsyncAwait(int n, int k)
        {
            
            var denominator = System.Threading.Tasks.Task.Run(() => CalculateDenominator(n, k));
            var factor = System.Threading.Tasks.Task.Run(() => CalculateFactor(k));

            await System.Threading.Tasks.Task.WhenAll(denominator, factor);

            return denominator.Result / factor.Result;
        }

        public void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);

            backgroundWorker1.WorkerReportsProgress = true;

            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }


        public void backgroundWorker1_DoWork(object sender,
            DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            e.Result = CalculateFibonacci((int)e.Argument, worker, e);
        }

        public void backgroundWorker1_RunWorkerCompleted(
            object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
                resultLabel.Text = "Canceled";
            else
                resultLabel.Text = e.Result.ToString();

            this.nFibValue.Enabled = true;

            startAsyncButton.Enabled = true;
        }

        public void backgroundWorker1_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        public long CalculateFibonacci(int n, BackgroundWorker worker, DoWorkEventArgs e)
        {
            long result = 0;

            if (n < 2)
            {
                result = 1;
            }
            else
            {
                result = CalculateFibonacci(n - 1, worker, e) +
                            CalculateFibonacci(n - 2, worker, e);
            }

            int percentComplete =
                (int)((float)n / (float)numberToCompute * 100);
            if (percentComplete > highestPercentageReached)
            {
                highestPercentageReached = percentComplete;
                worker.ReportProgress(percentComplete);
            }
            

            return result;
        }

        public void startAsyncButton_Click_1(object sender, EventArgs e)
        {
            resultLabel.Text = String.Empty;

            this.nFibValue.Enabled = false;

            this.startAsyncButton.Enabled = false;

            numberToCompute = (int)nFibValue.Value;

            highestPercentageReached = 0;

            backgroundWorker1.RunWorkerAsync(numberToCompute);
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            if(result == DialogResult.OK)
                Compression.CopressDirectory(new System.IO.DirectoryInfo(folderBrowser.SelectedPath));
        }

        private void decompressButton_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
                Compression.DecompressDirectory(new System.IO.DirectoryInfo(folderBrowser.SelectedPath));
        }
    }
}
