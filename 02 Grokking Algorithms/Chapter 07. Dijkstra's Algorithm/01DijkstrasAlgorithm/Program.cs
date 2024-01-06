namespace _01DijkstrasAlgorithm
{
    internal class Program
    {
        // Declare a dictionary to represent the graph where each key is a node and its value is another dictionary representing the adjacent nodes and their corresponding weights
        private static Dictionary<string, Dictionary<string, double>> graph = new Dictionary<string, Dictionary<string, double>>();

        // Define a constant for infinity
        private const double infinity = double.PositiveInfinity;

        // Declare a list to keep track of the nodes that have been processed
        private static List<string> processed = new List<string>();

        /// <summary>
        /// Function to find the node with the lowest cost that hasn't been processed yet
        /// </summary>
        /// <param name="costs"></param>
        /// <returns></returns>
        private static string? FindLowestCostNode(Dictionary<string, double> costs)
        {
            var lowestCost = double.PositiveInfinity;
            string? lowestCostNode = null;
            // Go through each node
            foreach(var node in costs)
            {
                var cost = node.Value;
                // Check if the current node's cost is less than the lowest cost found so far and if it hasn't been processed yet
                if (cost < lowestCost && !processed.Contains(node.Key))
                {
                    // Set it as the new lowest-cost node
                    lowestCost = cost;
                    lowestCostNode = node.Key;
                }
            }
            return lowestCostNode;
        }

        static void Main(string[] args)
        {
            // Initialize the graph
            graph.Add("Start", new Dictionary<string, double>());
            graph["Start"].Add("a", 6.0);
            graph["Start"].Add("b", 2.0);

            graph.Add("a", new Dictionary<string, double>());
            graph["a"].Add("Fin", 1.0);

            graph.Add("b", new Dictionary<string, double>());
            graph["b"].Add("a", 3.0);
            graph["b"].Add("Fin", 5.0);

            // The finish node doesn't have any neighbors
            graph.Add("Fin", new Dictionary<string, double>());

            // Initialize the costs table
            var costs = new Dictionary<string, double>();
            costs.Add("a", 6.0);
            costs.Add("b", 2.0);
            costs.Add("Fin", infinity);

            // Initialize the parents table
            var parents = new Dictionary<string, string>();
            parents.Add("a", "Start");
            parents.Add("b", "Start");
            parents.Add("Fin", null);

            // Start the algorithm to find the lowest cost path
            var node = FindLowestCostNode(costs);

            // Continue until all nodes have been processed
            while (node != null)
            {
                var cost = costs[node];
                var neighbors = graph[node];
                // Go through all the neighbors of this node
                foreach (var neighbor in neighbors.Keys)
                {
                    var new_cost = cost + neighbors[neighbor];
                    // If the cost to reach the neighbor through the current node is less than the previously known cost, update the cost and parent
                    if (costs[neighbor] > new_cost)
                    {
                        costs[neighbor] = new_cost;
                        parents[neighbor] = node;
                    }
                }
                // Mark the node as processed
                processed.Add(node);
                // Find the next node to process, and loop
                node = FindLowestCostNode(costs);
            }
            // Print the final costs
            Console.WriteLine(string.Join(", ", costs));
        }
    }
}
