namespace _07BinarySearchRecursive
{
    internal class Program
    {
        /// <summary>
        /// Performs a binary search on a sorted array to find the position of a target value.
        /// </summary>
        /// <param name="arr">The sorted array to search</param>
        /// <param name="target">The target value to find</param>
        /// <returns>The position of the target value in the array, or -1 if the target is not found</returns>
        static int BinarySearch(int[] arr, int target)
        {
            if (arr.Length == 0) return -1;

            int low = 0;
            int high = arr.Length - 1;
            int mid = (low + high) / 2;

            if (arr[mid] == target) return target;
            else if (arr[mid] > target) return BinarySearch(arr[..mid], target);
            else return BinarySearch(arr[(mid + 1)..], target);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(new int[] { 6, 7, 8, 9, 10 }, 9));

        }
    }
}