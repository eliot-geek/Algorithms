using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Graph_Depth_First_Search
{
    internal class Graph
    {
        // Represents the total number of vertices in the graph.
        private int vertexCount;

        // Represents an array of vertices in the graph.
        private Vertex[] vertices;

        // Represents the adjacency matrix that describes the edges between vertices.
        private int[,] adjacencyMatrix;

        /// <summary>
        /// Constructor to initialize the graph with a given number of vertices.
        /// </summary>
        /// <param name="vertexCount">The number of vertices in the graph.</param>
        public Graph(int vertexCount)
        {
            this.vertexCount = vertexCount;
            vertices = new Vertex[vertexCount];
            adjacencyMatrix = new int[vertexCount, vertexCount];
        }

        /// <summary>
        /// Method to add a vertex to the graph.
        /// </summary>
        /// <param name="data">The data of the vertex to be added.</param>
        public void AddVertex(string data)
        {
            for (int i = 0; i < vertexCount; i++)
            {
                if (vertices[i] == null)
                {
                    vertices[i] = new Vertex(data, false);
                    break;
                }
            }
        }

        /// <summary>
        /// Method to get the array of vertices.
        /// </summary>
        /// <returns>An array of vertices.</returns>
        public Vertex[] GetVertexs()
        {
            return vertices;
        }

        /// <summary>
        /// Method to get the adjacency matrix representing edges between vertices.
        /// </summary>
        /// <returns>The adjacency matrix.</returns>
        public int[,] GetAdjacencyMatrix()
        {
            return adjacencyMatrix;
        }

        /// <summary>
        /// Method to add an edge between two vertices.
        /// </summary>
        /// <param name="start">The index of the starting vertex.</param>
        /// <param name="end">The index of the ending vertex.</param>
        public void AddEdge(int start, int end)
        {
            adjacencyMatrix[start, end] = 1;

            // For an undirected graph, add this line to make the edge symmetric
            // adjacencyMatrix[end, start] = 1; 
        }

        /// <summary>
        /// Method to perform Depth-First Search traversal starting from each unvisited vertex.
        /// </summary>
        public void DepthFirstSearchRecursive()
        {
            bool[] visited = new bool[vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                if (!visited[i])
                {
                    DFS(i, visited);
                }
            }
        }

        /// <summary>
        /// Recursive method for Depth-First Search traversal.
        /// </summary>
        /// <param name="vertexIndex">The index of the current vertex.</param>
        /// <param name="visited">An array indicating whether each vertex is visited.</param>
        private void DFS(int vertexIndex, bool[] visited)
        {
            Console.Write(vertices[vertexIndex].data);

            visited[vertexIndex] = true;

            // Check if the current vertex is not the last one
            if (vertexIndex < vertexCount - 1)
            {
                Console.Write("-->");
            }

            for (int i = 0; i < vertexCount; i++)
            {
                if (adjacencyMatrix[vertexIndex, i] == 1 && !visited[i])
                {
                    DFS(i, visited);
                }
            }
        }


        /// <summary>
        /// Method to perform Depth-First Search traversal starting from each unvisited vertex using a stack.
        /// </summary>
        public void DepthFirstSearchWithStack()
        {
            bool[] visited = new bool[vertexCount];

            for (int i = 0; i < vertexCount; i++)
            {
                if (!visited[i])
                {
                    DFSWithStack(i, visited);
                }
            }
        }

        /// <summary>
        /// Method for Depth-First Search traversal using a stack.
        /// </summary>
        /// <param name="startVertex">The index of the starting vertex.</param>
        /// <param name="visited">An array indicating whether each vertex is visited.</param>
        private void DFSWithStack(int startVertex, bool[] visited)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(startVertex);

            while (stack.Count > 0)
            {
                int currentVertex = stack.Pop();

                Console.Write(vertices[currentVertex].data);

                visited[currentVertex] = true;

                // Use a temporary stack to reverse the order of pushing neighbors onto the main stack
                Stack<int> tempStack = new Stack<int>();

                for (int i = 0; i < vertexCount; i++)
                {
                    if (adjacencyMatrix[currentVertex, i] == 1 && !visited[i])
                    {
                        tempStack.Push(i);
                        visited[i] = true;
                    }
                }

                // Push the neighbors onto the main stack in the correct order
                while (tempStack.Count > 0)
                {
                    stack.Push(tempStack.Pop());
                }

                // Check if there are more vertices in the stack
                if (stack.Count > 0)
                {
                    Console.Write("-->");
                }
            }
        }
    }
}
