using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Stack_FILO
{
    internal class Stack
    {
        private Node top;
        private int size;

        /// <summary>
        /// Pushes a new element onto the stack.
        /// </summary>
        /// <param name="element">The element to be pushed onto the stack.</param>
        public void Push(String element)
        {
            if (top == null)
            {
                top = new Node(element);
            }
            else
            {
                Node newNode = new Node(element);
                newNode.next = top;
                top = newNode;
            }
            size++;
        }

        /// <summary>
        /// Pops (removes and returns) the top element from the stack.
        /// </summary>
        /// <returns>The node representing the popped element.</returns>
        public Node Pop()
        {
            if (top == null)
            {
                return null;
            }
            Node p = top;
            top = top.next;     // top move down
            p.next = null;
            size--;

            return p;
        }

        /// <summary>
        /// Gets the current size of the stack.
        /// </summary>
        /// <returns>The number of elements in the stack.</returns>
        public int Size()
        {
            return size;
        }
    }
}
