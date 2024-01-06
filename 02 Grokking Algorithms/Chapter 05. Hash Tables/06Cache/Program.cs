using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace _06Cache
{
    internal class Program
    {
        static Dictionary<string, string> cache = new Dictionary<string, string>();

        /// <summary>
        /// Retrieves a webpage from either the cache or the server
        /// </summary>
        /// <param name="url">The URL of the webpage to retrieve.</param>
        /// <returns>The content of the webpage as a string.</returns>
        public static async Task<string> GetPage(string url)
        {
            if (cache.ContainsKey(url))
            {
                return cache[url];
            }
            else
            {
                string data = await GetDataFromServer(url);
                cache[url] = data;
                return data;
            }
        }

        /// <summary>
        /// Fetches data from a server at a given URL
        /// </summary>
        /// <param name="url">The URL of the server to fetch data from.</param>
        /// <returns>The data retrieved from the server as a string, or null if an error occurred.</returns>
        public static async Task<string?> GetDataFromServer(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync(url);
                    return result;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", ex.Message);
                }
            }

            return null;
        }

        static async Task Main(string[] args)
        {
            // Using hash tables as a cache
            // Websites remember the data instead of recalculating it. So it stops making the server do work to figure out where to find what you ask every time.
            // You get the web page a lot faster and the servers have to do less 
            // Caching is a common way to make things faster. All big websites use caching.And that data is cached in a hash!

            //string url = "https://w";
            string url = "https://www.google.com";
            string page = await GetPage(url);
            Console.WriteLine(page);
        }
    }
}
