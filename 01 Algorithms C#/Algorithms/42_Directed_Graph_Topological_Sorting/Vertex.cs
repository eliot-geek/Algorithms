using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Directed_Graph_Topological_Sorting
{
    internal class Vertex
    {
        public String data;
        public bool visited;

        public Vertex(string data, bool visited)
        {
            this.data = data;
            this.visited = visited;
        }
    }
}
