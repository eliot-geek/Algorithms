using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Binary_Search_Tree_Maximum_And_Minimum
{
    internal class BinaryTree
    {
        private Node root;

        public Node GetRoot()
        {
            return root;
        }

        /// <summary>
        /// Finds the node containing the minimum value in the binary tree rooted at the specified node.
        /// </summary>
        /// <param name="node">The root node of the binary tree or subtree.</param>
        /// <returns>The node with the minimum value or null if the tree is empty or contains invalid data.</returns>
        public Node SearchMinValue(Node node)
        {
            if (node == null || node.data == 0)
            {
                return null;
            }

            if (node.left == null)
            {
                return node;
            }

            // Recursively find the minimum value from the left subtree
            return SearchMinValue(node.left);
        }

        /// <summary>
        /// Finds the node containing the maximum value in the binary tree rooted at the specified node.
        /// </summary>
        /// <param name="node">The root node of the binary tree or subtree.</param>
        /// <returns>The node with the maximum value or null if the tree is empty or contains invalid data.</returns>
        public Node SearchMaxValue(Node node)
        {
            if (node == null || node.data == 0)
            {
                return null;
            }

            if (node.right == null)
            {
                return node;
            }

            return SearchMaxValue(node.right);
        }

        /// <summary>
        /// Inserts a new node with the specified data into the binary tree rooted at the given node.
        /// If the tree is empty, a new root node is created.
        /// </summary>
        /// <param name="node">The root node of the binary tree or subtree where the insertion should occur.</param>
        /// <param name="newData">The data to be inserted into the binary tree.</param>
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
