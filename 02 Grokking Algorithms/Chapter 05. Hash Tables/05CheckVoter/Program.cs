using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05CheckVoter
{
    internal class Program
    {
        // Declare a static dictionary that maps strings (names) to booleans (voting status)
        private static Dictionary<string, bool> voted = new Dictionary<string, bool>();

        /// <summary>
        /// Checks if a voter has already voted.
        /// </summary>
        /// <param name="name">The name of the voter.</param>
        private static void CheckVoter(string name)
        {
            if (voted.ContainsKey(name))
            {
                Console.WriteLine("Kick them out");
            }
            else
            {
                voted.Add(name, true);
                Console.WriteLine("Let them vote!");
            }
        }

        static void Main(string[] args)
        {
            // Preventing duplicate entries
            // Suppose you’re running a voting booth. Naturally, every person can vote just once.How do you make sure they haven’t voted before?
            // When someone comes in to vote, you ask for their full name.hen you check it against the list of people who have voted.

            CheckVoter("Tom");
            CheckVoter("Mike");
            CheckVoter("Mike");
        }
    }
}
