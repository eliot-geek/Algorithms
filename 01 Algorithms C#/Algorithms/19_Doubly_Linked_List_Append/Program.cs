namespace _19_Doubly_Linked_List_Append
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

        public static void Append(Node newNode)
        {
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
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
            Append(new Node("Walnut"));
            Print(head);
        }
    }
}
