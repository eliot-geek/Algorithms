using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Hash_Table
{
    internal class Node
    {
        public Object key;
        public Object value;
        public int hash;
        public Node next;

        public Node(object key, object value, int hash, Node next)
        {
            this.key = key;
            this.value = value;
            this.hash = hash;
            this.next = next;
        }
    }
}
