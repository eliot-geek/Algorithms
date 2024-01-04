using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Doubly_Linked_List_Insert
{
    internal class Node
    {
        public String data;
        public Node prev;
        public Node next;

        public Node(string data)
        {
            this.data = data;
        }
    }
}
