using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Binary_Search_Tree_Maximum_And_Minimum
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
