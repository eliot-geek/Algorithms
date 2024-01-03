namespace _16_Unidirectional_Linked_List_Insert
{
    internal class Program
    {
        private static Node head;
        private static Node tail;

        public static Node Init()
        {
            // The first node called head node
            head = new Node("San Francisco", null);
            Node nodeOakland = new Node("Oakland", null);
            head.next = nodeOakland;

            Node nodeBerkeley = new Node("Berkeley", null);
            nodeOakland.next = nodeBerkeley;

            // The last node called tail node
            tail = new Node("Fremont", null);
            nodeBerkeley.next = tail;

            return head;
        }

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
            newNode.next = p.next;  // newNode next point to next node
            p.next = newNode;       // current next point to newNode
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
            Console.Write("Insert a new node Walnut at index = 2 : \n");
            Insert(2, new Node("Walnut", null));
            Print(head);
        }
    }
}
