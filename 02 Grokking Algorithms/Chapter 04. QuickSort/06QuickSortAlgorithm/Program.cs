namespace _06QuickSortAlgorithm
{
    internal class Program
    {
        /// <summary>
        /// Implements the QuickSort algorithm to sort an enumerable collection of integers in ascending order.
        /// </summary>
        /// <param name="array">The enumerable collection of integers to be sorted.</param>
        /// <returns>A new enumerable collection of integers sorted in ascending order.</returns>
        private static IEnumerable<int> QuickSort(IEnumerable<int> array)
        {
            if (array.Count() < 2) return array;
            int pivot = array.First();
            IEnumerable<int> less = array.Skip(1).Where(i => i <= pivot);
            IEnumerable<int> greater = array.Skip(1).Where(i => i > pivot);
            return QuickSort(less).Concat(new[] { pivot }).Concat(QuickSort(greater));
        }

        /// <summary>
        /// Implements the QuickSort algorithm to sort an enumerable collection of integers in ascending order.
        /// </summary>
        /// <param name="array">The enumerable collection of integers to be sorted.</param>
        /// <returns>A new enumerable collection of integers sorted in ascending order.</returns>
        private static IEnumerable<int> QuickSort2(IEnumerable<int> list)
        {
            if (list.Count() <= 1) return list;
            var pivot = list.First();
            var less = list.Skip(1).Where(i => i <= pivot);
            var greater = list.Skip(1).Where(i => i > pivot);
            return QuickSort2(less).Union(new List<int> { pivot }).Union(QuickSort2(greater));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", QuickSort(new[] { 10, 5, 2, 3 })));
            Console.WriteLine(string.Join(", ", QuickSort2(new[] { 10, 5, 2, 3 })));
        }
    }
}