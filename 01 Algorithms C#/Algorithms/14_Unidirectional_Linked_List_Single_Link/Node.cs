using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Unidirectional_Linked_List_Single_Link
{
    internal class Node
    {
        public String data;
        public Node next;

        public Node(String data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
