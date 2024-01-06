using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Binary_Search_Tree_Delete_Node
{
    internal class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
    }
}
