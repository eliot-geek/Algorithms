using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Binary_Search_Tree_In_Order_Traversal
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
