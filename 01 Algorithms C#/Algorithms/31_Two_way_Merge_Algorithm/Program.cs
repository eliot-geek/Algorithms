namespace _31_Two_way_Merge_Algorithm
{
    internal class Program
    {
        /// <summary>
        /// Initiates the MergeSort algorithm on the given array.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private static void MergeSort(int[] array)
        {
            MergeSort(array, new int[array.Length], 0, array.Length - 1);
        }

        /// <summary>
        /// Recursive helper function for MergeSort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        /// <param name="temp">Temporary array for merging.</param>
        /// <param name="left">Start index of the range to be sorted.</param>
        /// <param name="right">End index of the range to be sorted.</param>
        private static void MergeSort(int[] array, int[] temp, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;

                MergeSort(array, temp, left, center);               // Recursive call for Left merge sort
                MergeSort(array, temp, center + 1, right);          // Recursive call for Right merge sort
                Merge(array, temp, left, center + 1, right);        // Merge the two sorted halves
            }
        }

        /// <summary>
        /// Merges two ordered lists into a single ordered list.
        /// </summary>
        /// <param name="array">The array to be merged.</param>
        /// <param name="temp">Temporary array for merging.</param>
        /// <param name="left">Start index on the left.</param>
        /// <param name="right">Start index on the right.</param>
        /// <param name="rightEndIndex">End index on the right.</param>
        private static void Merge(int[] array, int[] temp, int left, int right, int rightEndIndex)
        {
            int leftEndIndex = right - 1;

            int tempIndex = left;
            int elementNumber = rightEndIndex - left + 1;

            // Merge the two halves
            while (left <= leftEndIndex && right <= rightEndIndex)
            {
                if (array[left] <= array[right])
                {
                    temp[tempIndex++] = array[left++];
                }
                else
                {
                    temp[tempIndex++] = array[right++];
                }
            }

            // If there are remaining elements on the left
            while (left <= leftEndIndex)
            {
                temp[tempIndex++] = array[left++];
            }

            // If there are remaining elements on the right
            while (right <= rightEndIndex)
            {
                temp[tempIndex++] = array[right++];
            }

            // Copy the merged elements back to the original array
            for (int i = 0; i < elementNumber; i++)
            {
                array[rightEndIndex] = temp[rightEndIndex];
                rightEndIndex--;
            }
        }

        static void Main(string[] args)
        {
            int[] scores = { 50, 65, 99, 87, 74, 63, 76, 100, 92 };
            MergeSort(scores);

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
