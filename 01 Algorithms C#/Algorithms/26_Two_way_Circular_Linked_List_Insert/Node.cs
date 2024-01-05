using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Two_way_Circular_Linked_List_Insert
{
    internal class Node
    {
        public String data;
        public Node next;
        public Node prev;

        public Node(string data)
        {
            this.data = data;
        }
    }
}
