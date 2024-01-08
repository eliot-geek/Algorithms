using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Graph_Depth_First_Search
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
