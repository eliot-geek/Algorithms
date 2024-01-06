namespace _03RecursiveSum
{
    internal class Program
    {
        /// <summary>
        /// Calculates the sum of all elements in the given integer array using recursion
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static int Summ(int[] list)
        {
            if (list.Length == 0) return 0;
            else return list[0] + Summ(list.Skip(1).ToArray());
        }

        /// <summary>
        /// Calculates the sum of all elements in the given enumerable collection of integers using recursion.
        /// </summary>
        /// <param name="list">The enumerable collection of integers.</param>
        /// <returns>The sum of all elements in the collection.</returns>
        private static int Sum(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;
            else return list.Take(1).First() + Sum(list.Skip(1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Summ(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
        }
    }
}