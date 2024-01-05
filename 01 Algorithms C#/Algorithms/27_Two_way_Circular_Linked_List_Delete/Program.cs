namespace _27_Two_way_Circular_Linked_List_Delete
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

        public static void Remove(int removePosition)
        {
            Node p = head;
            int i = 0;
            while (p.next != null && i < removePosition - 1)
            {
                p = p.next;
                i++;
            }

            Node temp = p.next;
            p.next = p.next.next;
            p.next.prev = p;
            temp.next = null;
            temp.prev = null;
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
            Remove(2);
            Print();
        }
    }
}
