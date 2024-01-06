namespace _36_Binary_Search_Tree_Maximum_And_Minimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Minimum value: The small value is on the left child node, as long as the recursion traverses the left child until be empty, the current node is the minimum node.
            Maximum value: The large value is on the right child node, as long as the recursive traversal is the right child until be empty, the current node is the largest node.
            */

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

            Console.Write("\nMinimum Value : ");
            Node minNode = binaryTree.SearchMinValue(binaryTree.GetRoot());
            Console.WriteLine(minNode.data);

            Console.Write("\nMinimum Value : ");
            Node maxNode = binaryTree.SearchMaxValue(binaryTree.GetRoot());
            Console.WriteLine(maxNode.data);
            Console.WriteLine();
        }
    }
}
