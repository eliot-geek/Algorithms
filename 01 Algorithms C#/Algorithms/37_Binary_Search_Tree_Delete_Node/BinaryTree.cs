using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Binary_Search_Tree_Delete_Node
{
    internal class BinaryTree
    {
        private Node root;

        public Node GetRoot()
        {
            return root;
        }

        /// <summary>
        /// Performs an in-order traversal of the binary tree.
        /// </summary>
        /// <param name="root">The current root node.</param>
        public void InOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            // Traversing
            InOrder(root.left);
            Console.Write(root.data + ",");
            InOrder(root.right);
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

        /// <summary>
        /// Deletes a node with the specified data from the binary tree.
        /// </summary>
        /// <param name="dataToDelete">The data to be deleted from the binary tree.</param>
        public void Remove(Node root, int dataToDelete)
        {
            root = DeleteNode(root, dataToDelete);
        }

        private Node DeleteNode(Node root, int key)
        {
            if (root == null)
            {
                return root;
            }

            // Recursive cases: Traverse the tree
            if (key < root.data)
            {
                root.left = DeleteNode(root.left, key);
            }
            else if (key > root.data)
            {
                root.right = DeleteNode(root.right, key);
            }
            else
            {
                // Node with only one child or no child
                if (root.left == null)
                {
                    return root.right;
                }
                else if (root.right == null)
                {
                    return root.left;
                }

                // Node with two children: Get the inorder successor (smallest in the right subtree)
                //root.data = MinValue(root.right);
                root.data = SearchMinValue(root.right).data;
                root.right = DeleteNode(root.right, root.data);

            }

            return root;
        }

        private int MinValue(Node root)
        {
            int minValue = root.data;
            while (root.left != null)
            {
                minValue = root.left.data;
                root = root.left;
            }
            return minValue;
        }

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

            return SearchMinValue(node.left);
        }
    }
}
