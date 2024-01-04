namespace _21_Doubly_Linked_List_Delete
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

        public static void Delete(int removePosition)
        {
            Node p = head;
            int i = 0;

            // Move the node to the previous node that was deleted
            while (p.next != null && i < removePosition - 1)
            {
                p = p.next;
                i++;
            }
            
            Node temp = p.next;     // Save the node you want to delete
            p.next = p.next.next;
            p.next.prev = p;

            temp.next = null;       // Set the delete node next to null
            temp.prev = null;       // Set the delete node prev to null
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
            Delete(2);
            Print(head);
        }
    }
}
