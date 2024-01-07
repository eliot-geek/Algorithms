using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Binary_Heap_Sorting
{
    internal class HeapSort
    {
        private int[] array;

        /// <summary>
        /// Creates a heap from the given array.
        /// </summary>
        /// <param name="array">The array to be transformed into a heap.</param>
        public void CreateHeap(int[] array)
        {
            this.array = array;

            // Build a heap, scan half of the nodes with child nodes
            for (int i = (array.Length - 1) / 2; i >= 0; i--)
            {
                AdjustHeap(i, array.Length - 1);
            }
        }


        /// <summary>
        /// Adjusts the heap to maintain the heap property starting from the specified index.
        /// </summary>
        /// <param name="currentIndex">The index to start adjusting the heap from.</param>
        /// <param name="maxLength">The maximum length of the heap.</param>
        public void AdjustHeap(int currentIndex, int maxLength)
        {
            int noLeafValue = array[currentIndex];

            // Current left subtree subscript
            for (int j = 2 * currentIndex + 1; j <= maxLength; j = currentIndex * 2 + 1)
            {
                if (j < maxLength && array[j] < array[j + 1])
                {
                    j++; // Choose the larger child node by comparing left and right child nodes.
                }
                if (noLeafValue >= array[j])
                {
                    break;
                }

                array[currentIndex] = array[j]; // Move up to the parent node
                currentIndex = j;
            }

            array[currentIndex] = noLeafValue; // Place the non-leaf value in its correct position.
        }

        /// <summary>
        /// Sorts the heap using the heap sort algorithm.
        /// </summary>
        public void PerformHeapSort()
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int temp = array[0];        // Store the value of the root node.
                array[0] = array[i];        // Replace the root node with the last element in the unsorted portion.
                array[i] = temp;            // Place the original root node value at the end of the sorted portion.
                AdjustHeap(0, i - 1);       // Adjust the heap to maintain the heap property after swapping elements.
            }
        }
    }
}
