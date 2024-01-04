using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Doubly_Linked_List
{
    internal class Node
    {
        public String data;
        public Node prev;
        public Node next;

        public Node(String data)
        {
            this.data = data;
        }
    }
}
