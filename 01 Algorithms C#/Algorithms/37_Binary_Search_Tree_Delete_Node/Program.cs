namespace _37_Binary_Search_Tree_Delete_Node
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.Write("\nDelete node is : 10");
            binaryTree.Remove(binaryTree.GetRoot(), 10);
            Console.WriteLine("\nIn-Order Traversal Binary Tree");
            binaryTree.InOrder(binaryTree.GetRoot());
            Console.WriteLine("\n______________________________");

            Console.Write("\nDelete node is : 20");
            binaryTree.Remove(binaryTree.GetRoot(), 20);
            Console.WriteLine("\nIn-Order Traversal Binary Tree");
            binaryTree.InOrder(binaryTree.GetRoot());
            Console.WriteLine("\n______________________________");

            Console.Write("\nDelete node is : 40");
            binaryTree.Remove(binaryTree.GetRoot(), 40);
            Console.WriteLine("\nIn-Order Traversal Binary Tree");
            binaryTree.InOrder(binaryTree.GetRoot());
            Console.WriteLine("\n______________________________");
            Console.WriteLine();
        }
    }
}
