namespace _08FindMax
{
    internal class Program
    {
        /// <summary>
        /// Finds the maximum value in a given array.
        /// </summary>
        /// <param name="arr">The array to search.</param>
        /// <returns>The maximum value in the array.</returns>
        static int FindMax(int[] arr)
        {
            // Base cases
            if (arr.Length == 0) return 0;
            else if (arr.Length == 1) return arr[0];
            else if (arr.Length == 2) return arr[0] > arr[1] ? arr[0] : arr[1];

            // Recursive case: find the maximum of the array recursively and compare it with the first element of the array
            int subMax = FindMax(arr[1..]);
            return arr[0] > subMax ? arr[0] : subMax;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 9, 4, 3, 2, 1 };
            Console.WriteLine(FindMax(arr));
        }
    }
}