using System.Net;

namespace _03IPAddresses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dnsLookup = new Dictionary<string, string>();
            dnsLookup["adit.io"] = "173.255.248.55";
            dnsLookup["google.com"] = "74.125.239.139";
            dnsLookup["facebook.com"] = "173.252.120.6";
            dnsLookup["scribd.com"] = "23.235.47.175";
            foreach (KeyValuePair<string, string> item in dnsLookup)
            {
                Console.WriteLine("Key: {0}, IP Address: {1}", item.Key, item.Value);
            }
            Console.WriteLine();


            //  DNS resolution
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry("adit.io");
                Console.WriteLine("Host Name: " + hostInfo.HostName);
                foreach(IPAddress address in hostInfo.AddressList)
                {
                    Console.WriteLine("IP Address: " + address.ToString());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("An error occured: " + exception.Message);
            }
        }
    }
}
