namespace _33_Binary_Search_Tree_In_Order_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // binary search tree In-order traversal
            // In - order traversal: left subtree -> root node -> right subtree

            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(binaryTree.GetRoot(), 60);
            binaryTree.Insert(binaryTree.GetRoot(), 40);
            binaryTree.Insert(binaryTree.GetRoot(), 20);
            binaryTree.Insert(binaryTree.GetRoot(), 10);
            binaryTree.Insert(binaryTree.GetRoot(), 30);
            binaryTree.Insert(binaryTree.GetRoot(), 50);
            binaryTree.Insert(binaryTree.GetRoot(), 80);
            binaryTree.Insert(binaryTree.GetRoot(), 70);
            binaryTree.Insert(binaryTree.GetRoot(), 90);

            Console.Write("In-order Traversal Binary Search Tree\n");
            binaryTree.InOrder(binaryTree.GetRoot());
            Console.WriteLine();
        }
    }
}
