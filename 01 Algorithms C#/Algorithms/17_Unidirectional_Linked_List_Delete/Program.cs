using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace _17_Unidirectional_Linked_List_Delete
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

        public static void Delete(int deletePosition)
        {
            Node p = head;
            int i = 0;

            // Move the node to the previous node position that was deleted
            while (p.next != null && i < deletePosition - 1)
            {
                p = p.next;
                i++;
            }
            Node temp = p.next;     // Save the node you want to delete
            p.next = p.next.next;   // Previous node next points to next of delete the node
            temp.next = null;
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
            Console.Write("Delete a new node Berkeley at index = 2 : \n");
            Delete(2);
            Print(head);
        }
    }
}
