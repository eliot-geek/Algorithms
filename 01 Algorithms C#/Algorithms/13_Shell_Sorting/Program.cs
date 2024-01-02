namespace _13_Shell_Sorting
{
    internal class Program
    {
        public static void ShellSort(int[] array)
        {
            for (int gap = array.Length / 2; gap > 0; gap = gap / 2)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    int j = i;
                    while (j - gap >= 0 && array[j] < array[j - gap])
                    {
                        Swap(array, j, j - gap);
                        j -= gap;
                    }
                }
            }
        }

        public static void Swap(int[] array, int a, int b)
        {
            array[a] = array[a] + array[b];
            array[b] = array[a] - array[b];
            array[a] = array[a] - array[b];
        }

        static void Main(string[] args)
        {
            // Shell Sorting - is a highly efficient sorting algorithm and is based on insertion sort algorithm.
            // This algorithm avoids large shifts as in case of insertion sort, if the smaller value is to the far right and has to be moved to the far left.
            int[] scores = { 9, 6, 5, 8, 0, 7, 4, 3, 1, 2 };
            ShellSort(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
