namespace _01BreadthFirstSearchAlgo
{
    internal class Program
    {
        // Declare a dictionary to represent a graph where keys are names and values are arrays of names connected to the key
        private static Dictionary<string, string[]> graph = new Dictionary<string, string[]>();

        /// <summary>
        /// Function to search for a mango seller in the graph starting from a given name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static bool Search(string name)
        {
            // Create a queue to hold the names to be searched and a list to keep track of the names already searched
            var searchQueue = new Queue<string>(graph[name]);
            var searched = new List<string>();

            // Continue searching as long as there are names in the queue
            while (searchQueue.Any())
            {
                var person = searchQueue.Dequeue();
                if (!searched.Contains(person))
                {
                    if (PersonIsSeller(person))
                    {
                        Console.WriteLine($"{person} is a mango seller");
                        return true;
                    }
                    else
                    {
                        searchQueue = new Queue<string>(searchQueue.Concat(graph[person]));
                        searched.Add(person);
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Function to check if a person is a mango seller
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static bool PersonIsSeller(string name)
        {
            return name.EndsWith("m");
        }

        static void Main(string[] args)
        {
            // Add people to the graph
            graph.Add("you", new[] { "Alice", "Bob", "Claire" });
            graph.Add("Bob", new[] { "Anuj", "Peggy" });
            graph.Add("Alice", new[] { "Peggy" });
            graph.Add("Claire", new[] { "Thom", "Jonny" });
            graph.Add("Anuj", Array.Empty<string>());
            graph.Add("Peggy", Array.Empty<string>());
            graph.Add("Thom", Array.Empty<string>());
            graph.Add("Jonny", Array.Empty<string>());

            Search("you");
        }
    }
}
