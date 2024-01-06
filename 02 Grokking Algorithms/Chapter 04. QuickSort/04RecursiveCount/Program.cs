namespace _04RecursiveCount
{
    internal class Program
    {
        /// <summary>
        /// Counts recursively the number of elements in a list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static int Count(int[] list)
        {
            if (!list.Any()) return 0;
            else return 1 + Count(list.Skip(1).ToArray());
        }

        private static int Count(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;
            else return 1 + Count(list.Skip(1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Count(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(Count(new[] { 1, 2, 3, 4 }));
        }
    }
}