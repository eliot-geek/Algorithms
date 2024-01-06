namespace _02LoopSum
{
    internal class Program
    {
        /// <summary>
        /// Calculates the sum of all elements in the given array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>returns the total sum</returns>
        static int Summa(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }

        /// <summary>
        /// Calculates the sum of all elements in the given IEnumerable array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int Sum(IEnumerable<int> arr)
        {
            int total = 0;
            foreach (int item in arr)
            {
                total += item;
            }
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Summa(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
        }
    }
}