namespace _32_QuickSort_Algorithm
{
    internal class Program
    {
        /// <summary>
        /// Public method to initiate the QuickSort algorithm on an integer array.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        public static void QuickSort(int[] array)
        {
            if (array.Length > 0)
            {
                QuickSort(array, 0, array.Length - 1);
            }
        }

        /// <summary>
        /// Private method implementing the QuickSort algorithm on a portion of an integer array.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        /// <param name="low">The starting index of the subarray.</param>
        /// <param name="high">The ending index of the subarray.</param>
        private static void QuickSort(int[] array, int low, int high)
        {
            if (low > high)
            {
                return;
            }

            int i = low;
            int j = high;
            int threshold = array[low];

            // Alternately scanned from both ends of the list
            while (i < j)
            {
                // Find the first position less than threshold from right to left
                while (i < j && array[j] > threshold)
                {
                    j--;
                }

                // Replace the low with a smaller number than the threshold
                if (i < j)
                {
                    array[i++] = array[j];
                }

                // Find the first position greater than threshold from left to right
                while ( i < j && array[i] <= threshold)
                {
                    i++;
                }

                // Replace the high with a number larger than the threshold
                if (i < j)
                {
                    array[j--] = array[i];
                }

                array[i] = threshold;               // Restore the threshold element to its correct position
                QuickSort(array, low, i - 1);       // Left QuickSort
                QuickSort(array, i + 1, high);      // Right QuickSort
            }
        }

        static void Main(string[] args)
        {
            int[] scores = { 90, 60, 50, 80, 70, 100 };
            QuickSort(scores);

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
