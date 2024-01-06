namespace _05RecursiveMax
{
    internal class Program
    {
        /// <summary>
        /// Finds recursively the maximum element in a list
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        static int? Max(int[] lst)
        {
            if (lst.Length == 0) return null;
            else if (lst.Length == 1) return lst[0];
            else if (lst.Length == 2) return lst[0] > lst[1] ? lst[0] : lst[1];
            else
            {
                int? sub_max = Max(lst.Skip(1).ToArray());
                return lst[0] > sub_max ? lst[0] : sub_max;
            }
        }

        /// <summary>
        /// Finds recursively the maximum element in a collection of integers
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static int Max(IEnumerable<int> list)
        {
            // Base cases
            if (!list.Any()) return 0;
            if (list.Count() == 1) return list.First();
            if (list.Count() == 2) return list.First() > list.Skip(1).Take(1).First() ? list.First() : list.Skip(1).Take(1).First();

            // Recursive case
            var sub_max = Max(list.Skip(1));
            return list.First() > sub_max ? list.First() : sub_max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Max(new int[] { 10, 5, 2, 3 }));
            Console.WriteLine(Max(new List<int> {8, 5, 2, 3 }));
            Console.WriteLine(Max(new[] { 1, 3, 2, 5, 9, 8 }));
        }
    }
}