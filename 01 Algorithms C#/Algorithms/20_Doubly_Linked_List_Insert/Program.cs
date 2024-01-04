namespace _20_Doubly_Linked_List_Insert
{
    internal class Program
    {
        private static Node head;
        private static Node tail;

        public static void Init()
        {
            head = new Node("San Francisco");
            head.prev = null;
            head.next = null;

            Node nodeOakland = new Node("Oakland");
            nodeOakland.prev = head;
            nodeOakland.next = null;
            head.next = nodeOakland;

            Node nodeBerkeley = new Node("Berkeley");
            nodeBerkeley.prev = nodeOakland;
            nodeBerkeley.next = null;
            nodeOakland.next = nodeBerkeley;

            tail = new Node("Fremont");
            tail.prev = nodeBerkeley;
            tail.next = null;
            nodeBerkeley.next = tail;
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

        public static void Print(Node node)
        {
            Node p = node;
            Node end = null;
            while (p != null)
            {
                Console.Write(p.data + "-->");
                end = p;
                p = p.next;
            }
            Console.Write("End\n");
            p = end;

            while (p != null)
            {
                Console.Write(p.data + "-->");
                p = p.prev;
            }
            Console.Write("Start\n");
        }

        static void Main(string[] args)
        {
            Init();
            Insert(2, new Node("Walnut"));
            Print(head);
        }
    }
}
