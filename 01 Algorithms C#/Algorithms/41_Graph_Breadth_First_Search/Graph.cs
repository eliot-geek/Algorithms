using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Graph_Breadth_First_Search
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
        /// Method to perform Breadth-First Search traversal starting from each unvisited vertex.
        /// </summary>
        public void BreadthFirstSearch()
        {
            bool[] visited = new bool[vertexCount];

            // Perform BFS starting from each unvisited vertex
            for (int i = 0; i < vertexCount; i++)
            {
                if (!visited[i])
                {
                    BFS(i, visited);
                }
            }
        }


        /// <summary>
        /// Helper method for Breadth-First Search traversal.
        /// </summary>
        /// <param name="startVertex">The index of the starting vertex.</param>
        /// <param name="visited">An array indicating whether each vertex is visited.</param>
        private void BFS(int startVertex, bool[] visited)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                int currentVertex = queue.Dequeue();
                Console.Write(vertices[currentVertex].data);

                // Check if the current vertex is not the last one
                if (currentVertex < vertexCount - 1)
                {
                    Console.Write("-->");
                }

                visited[currentVertex] = true;

                for (int i = 0; i < vertexCount; i++)
                {
                    if (adjacencyMatrix[currentVertex, i] == 1 && !visited[i])
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }
    }
}
