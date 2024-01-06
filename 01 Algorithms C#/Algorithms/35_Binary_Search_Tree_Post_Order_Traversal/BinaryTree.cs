using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Binary_Search_Tree_Post_Order_Traversal
{
    internal class BinaryTree
    {
        private Node root;

        /// <summary>
        /// Gets the root of the binary tree.
        /// </summary>
        /// <returns>The root node.</returns>
        public Node GetRoot()
        {
            return root;
        }

        /// <summary>
        /// Performs an Post-order traversal of the binary tree.
        /// </summary>
        /// <param name="root">The current root node.</param>
        public void PostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.data + ",");
        }

        /// <summary>
        /// Inserts a new node with specified data into the binary tree.
        /// </summary>
        /// <param name="node">The current node being considered during insertion.</param>
        /// <param name="newData">The data to be inserted.</param>
        public void Insert(Node node, int newData)
        {
            if (this.root == null)
            {
                this.root = new Node(newData, null, null);
                return;
            }

            // Ensure that node is not null before accessing its properties
            if (node != null)
            {
                int compareValue = newData - node.data;

                // Recursive left subtree, continue to find the insertion position
                if (compareValue < 0)
                {
                    if (node.left == null)
                    {
                        node.left = new Node(newData, null, null);
                    }
                    else
                    {
                        Insert(node.left, newData);
                    }
                }

                // Recursive right subtree, continue to find the insertion position
                else if (compareValue > 0)
                {
                    if (node.right == null)
                    {
                        node.right = new Node(newData, null, null);
                    }
                    else
                    {
                        Insert(node.right, newData);
                    }
                }
            }
        }
    }
}
