using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Directed_Graph_Topological_Sorting
{
    internal class Graph
    {
        // Represents the total number of vertices in the graph.
        private int vertexCount;

        // Represents an array of vertices in the graph.
        private Vertex[] vertices;

        // Represents the adjacency matrix that describes the edges between vertices.
        private int[,] adjacencyMatrix;

        public List<Vertex> Topologys { get; private set; }

        /// <summary>
        /// Constructor to initialize the graph with a given number of vertices.
        /// </summary>
        /// <param name="vertexCount">The number of vertices in the graph.</param>
        public Graph(int vertexCount)
        {
            this.vertexCount = vertexCount;
            vertices = new Vertex[vertexCount];
            adjacencyMatrix = new int[vertexCount, vertexCount];
            Topologys = new List<Vertex>();
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
        }

        /// <summary>
        /// Performs topological sorting of the graph and returns the sorted vertices.
        /// </summary>
        /// <returns>List of vertices in topological order.</returns>
        public List<Vertex> TopologySort()
        {
            var topologys = new List<Vertex>();
            var visited = new bool[vertexCount];

            for (int i = 0; i < vertexCount; i++)
            {
                if (!visited[i])
                {
                    Visit(i, visited, topologys);
                }
            }

            return topologys;
        }

        /// <summary>
        /// Recursive method to visit vertices and perform topological sorting.
        /// </summary>
        /// <param name="vertexIndex">Index of the current vertex.</param>
        /// <param name="visited">Array indicating whether each vertex is visited.</param>
        /// <param name="topologys">List to store the vertices in topological order.</param>
        private void Visit(int vertexIndex, bool[] visited, List<Vertex> topologys)
        {
            visited[vertexIndex] = true;

            for (int i = 0; i < vertexCount; i++)
            {
                if (adjacencyMatrix[vertexIndex, i] != 0 && !visited[i])
                {
                    Visit(i, visited, topologys);
                }
            }

            topologys.Insert(0, vertices[vertexIndex]);
        }

        /// <summary>
        /// Gets a string representation of the topological order of vertices.
        /// </summary>
        /// <returns>String representing the topological order.</returns>
        public string GetTopologys()
        {
            var topologys = TopologySort();
            var result = "";

            foreach (var vertex in topologys)
            {
                result += $"{vertex.data}->";
            }

            return result.TrimEnd("->".ToCharArray());
        }


        /// <summary>
        /// Perform topological sorting of the graph vertices.
        /// </summary>
        public void TopologySortQueue()
        {
            // Calculate in-degrees for each vertex
            int[] inDegrees = new int[vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    inDegrees[j] += adjacencyMatrix[i, j];
                }
            }

            // Queue to store vertices with zero in-degrees
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < vertexCount; i++)
            {
                if (inDegrees[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            // Process vertices in topological order
            while (queue.Count > 0)
            {
                int currentVertex = queue.Dequeue();

                // Save to topologys
                Topologys.Add(vertices[currentVertex]);

                // Update in-degrees and enqueue vertices with zero in-degrees
                for (int i = 0; i < vertexCount; i++)
                {
                    if (adjacencyMatrix[currentVertex, i] == 1)
                    {
                        inDegrees[i]--;
                        if (inDegrees[i] == 0)
                        {
                            queue.Enqueue(i);
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Get the array of vertices after topological sorting.
        /// </summary>
        /// <returns>An array of vertices in topological order.</returns>
        public Vertex[] GetTopologysQueue()
        {
            return Topologys.ToArray();
        }
    }
}
