namespace _03Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Recap
            /*
            • Breadth-first search is used to calculate the shortest path for an unweighted graph.
            • Dijkstra’s algorithm is used to calculate the shortest path for a weighted graph.
            • Dijkstra’s algorithm works when all the weights are positive.
            • If you have negative weights, use the Bellman-Ford algorithm.
            
            Breadth-first search is not necessarily the fastest path. It’s the shortest path, because it has the least number of segments.
            Breadth-irst search will find you the path with the fewest segments. 

            You’ll use Dijkstra’s algorithm to go from start to finish in the shortest possible time.
            There are four steps to Dijkstra’s algorithm:
            1. Find the “cheapest” node. This is the node you can get to in the least amount of time.
            2. Update the costs of the neighbors of this node. I’ll explain what I mean by this shortly.
            3. Repeat until you’ve done this for every node in the graph.
            4. Calculate the inal path.

            Terminology
            A graph with weights is called a weighted graph. A graph without weights is called an unweighted graph.
            Each edge in the graph has a number associated with it. These are called weights.

            To calculate the shortest path in an unweighted graph, use breadth-first search. 
            To calculate the shortest path in a weighted graph, use Dijkstra’s algorithm. 
            Graphs can also have cycles - An undirected graph means that both nodes point to each other. That’s a cycle!
            With an undirected graph, each edge adds another cycle. Dijkstra’s algorithm only works with directed acyclic graphs, called DAGs for short.

            Negative-weight edges
            You can’t use Dijkstra’s algorithm if you have negative-weight edges. 
            If you want to ind the shortest path in a graph that has negative-weight edges, there’s an algorithm for that! It’s called the Bellman-Ford algorithm.

            */
            #endregion

            Console.WriteLine("Dijkstra's Algorithm");
        }
    }
}
