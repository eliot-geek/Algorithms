namespace _09SumArray
{
    internal class Program
    {
        /// <summary>
        /// Calculates the sum of all elements in a given array recursively
        /// </summary>
        /// <param name="arr">The array to sum.</param>
        /// <returns>The sum of all elements in the array.</returns>
        static int SumArray(int[] arr)
        {
            if (arr.Length == 0) return 0;
            else return arr[0] + SumArray(arr[1..]);
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumArray(arr));
        }
    }
}