namespace _03_Bubble_Sorting_Algorithm
{
    internal class Program
    {
        public static void Sort(int[] arrays)
        {
            for (int i = 0; i < arrays.Length - 1; i++)
            {
                for (int j = 0; j < arrays.Length - i - 1; j++)
                {
                    // Swap
                    if (arrays[j] > arrays[j + 1])
                    {
                        int temp = arrays[j];
                        arrays[j] = arrays[j + 1];
                        arrays[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Sort the following numbers from small to large
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            Sort(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
