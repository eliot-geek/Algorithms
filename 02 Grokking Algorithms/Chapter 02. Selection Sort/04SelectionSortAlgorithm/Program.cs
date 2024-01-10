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
            // Selection sort is a neat algorithm, but it’s not very fast. Quicksort is a faster sorting algorithm that only takes O(n log n) time. 
            
            int[] arr = new int[] { 5, 3, 6, 2, 10 };
            Console.WriteLine("Original array: " + string.Join(", ", arr)); // concatenate all the elements of the array, using a specified separator between each element
            int[] sortedArr = SelectionSort(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", sortedArr));
        }
    }
}
