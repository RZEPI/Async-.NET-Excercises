using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace lab5
{
    internal class HostNames
    {
        static string[] hostNames = { "www.microsoft.com", "www.apple.com",
                                "www.google.com", "www.ibm.com", "cisco.netacad.net",
                                "www.oracle.com", "www.nokia.com", "www.hp.com", "www.dell.com",
                                "www.samsung.com", "www.toshiba.com", "www.siemens.com",
                                "www.amazon.com", "www.sony.com", "www.canon.com", "www.alcatellucent.com",
                                "www.acer.com", "www.motorola.com" };
        public static List<Tuple<string, string>> MapDomains()
        {
            List<Tuple<string, string>> namesAndIps = new List<Tuple<string, string>>();
            object locker = new object();
            hostNames.AsParallel().ForAll(hostName =>
                                                {
                                                    lock (locker)
                                                    {
                                                        try
                                                        {
                                                            namesAndIps.Add(Tuple.Create(hostName, Dns.GetHostAddresses(hostName).First().ToString()));
                                                        }
                                                        catch (System.Net.Sockets.SocketException)
                                                        { 
                                                            namesAndIps.Add(Tuple.Create(hostName, "connectionError"));
                                                        }
                                                    }
                                                });
            return namesAndIps;
        }
    }
}
