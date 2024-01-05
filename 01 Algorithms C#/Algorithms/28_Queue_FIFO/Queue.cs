using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Queue_FIFO
{
    internal class Queue
    {
        private Node head;
        private Node tail;
        private int size;

        /// <summary>
        /// Adds an element to the end of the queue.
        /// </summary>
        /// <param name="element">The element to be added to the queue.</param>
        public void Offer(String element)
        {
            if (head == null)
            {
                // If the queue is empty, create a new node as both head and tail
                head = new Node(element);
                tail = head;
            }
            else
            {
                // If the queue is not empty, create a new node and update tail references
                Node newNode = new Node(element);
                newNode.next = tail;
                tail.prev = newNode;
                tail = newNode;
            }

            size++;
        }

        /// <summary>
        /// Removes and returns the element at the front of the queue.
        /// </summary>
        /// <returns>The node removed from the front of the queue, or null if the queue is empty.</returns>
        public Node Poll()
        {
            // Node to be removed
            Node p = head;

            // Return null if the queue is empty
            if (p == null)
            {
                return null; 
            }

            // Move head to the next node
            head = head.prev; 
            p.next = null;
            p.prev = null;
            size--;

            return p;
        }

        /// <summary>
        /// Returns the current size of the queue.
        /// </summary>
        /// <returns>The size of the queue.</returns>
        public int Size()
        {
            return size;
        }
    }
}
