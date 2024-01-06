namespace _06Count
{
    internal class Program
    {
        /// <summary>
        /// Function Count
        /// </summary>
        /// <param name="arr">integer array arr</param>
        /// <returns>the number of elements in the array</returns>
        static int Count(int[] arr)
        {
            if (arr.Length == 0) return 0;      // Base case
            else return 1 + Count(arr[1..]);    // allows to get a slice of an array starting from a specific index to the end of the array - Recursive case
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Count(arr)); // Output: 5
        }
    }
}