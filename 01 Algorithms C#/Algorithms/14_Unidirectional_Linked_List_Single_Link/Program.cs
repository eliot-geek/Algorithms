namespace _14_Unidirectional_Linked_List_Single_Link
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
            // Unidirectional Linked List - Is a chained storage structure of a linear table, which is connected by a node.
            // UML Diagram - Unified Modeling Language

            Init();
            Print(head);
        }
    }
}
