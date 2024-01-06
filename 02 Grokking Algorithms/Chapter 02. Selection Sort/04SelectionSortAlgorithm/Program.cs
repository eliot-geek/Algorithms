using System.Xml.Linq;

namespace _04SelectionSortAlgorithm
{
    internal class Program
    {
        /// <summary>
        /// Find the index of the smallest element in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int FindSmallest(int[] arr)
        {
            int smallest = arr[0];
            int smallestIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        /// <summary>
        /// Sort the array using selection sort
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int[] SelectionSort(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int smallest = FindSmallest(arr);
                newArr[i] = arr[smallest];
                arr[smallest] = int.MaxValue;
            }
            return newArr;
        }

        static void Main(string[] args)
        {
            /* Let’s put it all together to learn your second algorithm:
            selection sort. To follow this section, you need to understand arrays and lists, as well as Big O notation.
            Suppose you have a bunch of music on your computer. For each artist, you have a play count.
            You want to sort this list from most to least played, so that you can rank your favorite artists. How can you do it?
            One way is to go through the list and ind the most-played artist. Add that artist to a new list.
            Do it again to ind the next-most-played artist.
            Keep doing this, and you’ll end up with a sorted list.

            This takes O(n × n) time or O(n2) time.
            Sorting algorithms are very useful. Now you can sort
            • Names in a phone book
            • Travel dates
            • Emails (newest to oldest)

            Selection sort is a neat algorithm, but it’s not very fast. Quicksort is a faster sorting algorithm that only takes O(n log n) time. 
            It’s coming up in the next chapter!
             */

            int[] arr = new int[] { 5, 3, 6, 2, 10 };
            Console.WriteLine("Original array: " + string.Join(", ", arr)); // concatenate all the elements of the array, using a specified separator between each element
            int[] sortedArr = SelectionSort(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", sortedArr));
        }
    }
}