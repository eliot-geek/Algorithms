namespace _23_One_way_Circular_Linked_List_Insert
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
        /// Inserts a new node at the specified position in the one-way circular linked list.
        /// </summary>
        /// <param name="insertPosition">The position at which the new node should be inserted.</param>
        /// <param name="newNode">The new node to be inserted.</param>
        public static void Insert(int insertPosition, Node newNode)
        {
            Node p = head;
            int i = 0;

            // Move the node to the insertion position
            while (p.next != null && i < insertPosition - 1)
            {
                p = p.next;
                i++;
            }

            newNode.next = p.next;
            p.next = newNode;
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
            Insert(2, new Node("E"));
            Print();
        }
    }
}
