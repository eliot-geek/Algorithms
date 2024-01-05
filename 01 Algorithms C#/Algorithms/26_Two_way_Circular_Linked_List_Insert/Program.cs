namespace _26_Two_way_Circular_Linked_List_Insert
{
    internal class Program
    {
        private static Node head;
        private static Node tail;

        public static void Init()
        {
            head = new Node("A");
            head.next = null;
            head.prev = null;

            Node nodeB = new Node("B");
            nodeB.next = null;
            nodeB.prev = head;
            head.next = nodeB;

            Node nodeC = new Node("C");
            nodeC.next = null;
            nodeC.prev = nodeB;
            nodeB.next = nodeC;

            tail = new Node("D");
            tail.next = head;
            tail.prev = nodeC;
            nodeC.next = tail;
            head.prev = tail;
        }

        public static void Insert(int insertPosition, Node newNode)
        {
            Node p = head;
            int i = 0;
            while (p.next != null && i < insertPosition - 1)
            {
                p = p.next;
                i++;
            }
            newNode.next = p.next;
            p.next = newNode;
            newNode.prev = p;
            newNode.next.prev = newNode;
        }

        public static void Print()
        {
            Node p = head;
            do
            {
                Console.Write(p.data + "-->");
                p = p.next;
            } while (p != head);
            Console.Write(p.data + "\n");

            p = tail;
            do
            {
                Console.Write(p.data + "-->");
                p = p.prev;
            } while (p != tail);
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
