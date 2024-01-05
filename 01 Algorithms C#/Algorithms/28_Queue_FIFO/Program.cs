namespace _28_Queue_FIFO
{
    internal class Program
    {
        /// <summary>
        /// Prints the elements of the queue from head to tail.
        /// </summary>
        /// <param name="queue">The queue to be printed.</param>
        public static void Print(Queue queue)
        {
            Console.Write("Head ");
            Node node = null;

            // Dequeue elements until the queue is empty
            while ((node = queue.Poll()) != null)
            {
                Console.Write(node.data + "<--");
            }

            Console.Write(" Tail\n");
        }

        static void Main(string[] args)
        {
            Queue queue = new Queue();      // Create a new queue instance
            queue.Offer("A");               // Enqueue element and so on
            queue.Offer("B");
            queue.Offer("C");
            queue.Offer("D");

            Print(queue);
        }
    }
}
