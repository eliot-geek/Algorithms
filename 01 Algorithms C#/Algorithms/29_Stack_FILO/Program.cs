namespace _29_Stack_FILO
{
    internal class Program
    {
        public static void Print(Stack stack)
        {
            Console.Write("Top ");
            Node node = null;

            while ((node = stack.Pop()) != null)
            {
                Console.Write(node.data + "-->");
            }
            Console.Write(" End\n");
        }

        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");

            Print(stack);
        }
    }
}
