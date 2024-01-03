namespace _15_Unidirectional_Linked_List_Append
{
    internal class Program
    {
        private static Node head;
        private static Node tail;

        public static Node Init()
        {
            head = new Node("San Francisco", null);
            Node nodeOakland = new Node("Oakland", null);
            head.next = nodeOakland;

            Node nodeBerkeley = new Node("Berkeley", null);
            nodeOakland.next = nodeBerkeley;

            tail = new Node("Fremont", null);
            nodeBerkeley.next = tail;

            return head;
        }

        public static void Append(Node newNode)
        {
            tail.next = newNode;
            tail = newNode;
        }

        public static void Print(Node node)
        {
            Node p = node;
            while (p != null)
            {
                Console.Write(p.data + "-->");
                p = p.next;
            }
            Console.Write("End\n");
        }

        static void Main(string[] args)
        {
            Init();
            Append(new Node("Walnut", null));
            Print(head);
        }
    }
}
