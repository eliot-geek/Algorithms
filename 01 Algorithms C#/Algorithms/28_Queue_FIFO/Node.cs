using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Queue_FIFO
{
    internal class Node
    {
        public String data;
        public Node next;
        public Node prev;

        /// <summary>
        /// Constructor for creating a new node with the given data.
        /// </summary>
        /// <param name="data">The data to be stored in the node.</param>
        public Node(string data)
        {
            this.data = data;
        }
    }
}
