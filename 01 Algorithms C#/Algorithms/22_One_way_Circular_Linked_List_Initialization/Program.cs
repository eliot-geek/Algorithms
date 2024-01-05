namespace _22_One_way_Circular_Linked_List_Initialization
{
    internal class Program
    {
        private static Node head;
        private static Node tail;

        /// <summary>
        /// Initializes a one-way circular linked list with sample nodes A, B, C, and D.
        /// </summary>
        public static void Init()
        {
            // The first node called head node
            head = new Node("A");
            head.next = null;

            Node nodeB = new Node("B");
            nodeB.next = null;
            head.next = nodeB;

            Node nodeC = new Node("C");
            nodeC.next = null;
            nodeB.next = nodeC;

            // The last node called tail node
            tail = new Node("D");
            tail.next = head;
            nodeC.next = tail;
        }

        /// <summary>
        /// Prints the elements of the one-way circular linked list.
        /// </summary>
        public static void Print()
        {
            Node p = head;
            do
            {
                Console.Write(p.data + "-->");
                p = p.next;
            } while (p != head);
            Console.Write(p.data + "\n");
        }

        static void Main(string[] args)
        {
            Init();
            Print();
        }
    }
}
