namespace _40_Graph_Depth_First_Search
{
    internal class Program
    {
        public static void PrintGraph(Graph graph)
        {
            Console.Write("Two-dimensional array traversal vertex edge and adjacent array : \n\n  ");

            for (int i = 0; i < graph.GetVertexs().Length; i++)
            {
                Console.Write(graph.GetVertexs()[i].data + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < graph.GetAdjacencyMatrix().GetLength(0); i++)
            {
                Console.Write(graph.GetVertexs()[i].data + " ");
                for (int j = 0; j < graph.GetAdjacencyMatrix().GetLength(0); j++)
                {
                    Console.Write(graph.GetAdjacencyMatrix()[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // Directed Graph and Depth First Search

            Graph graph = new Graph(5);
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            // Two-dimensional array traversal output vertex edge and adjacent arrray
            PrintGraph(graph);
            Console.Write("\nDepth-first Search traversal output : \n\n");
            graph.DepthFirstSearchWithStack();
            //graph.DepthFirstSearchRecursive();
            Console.WriteLine();
        }
    }
}
