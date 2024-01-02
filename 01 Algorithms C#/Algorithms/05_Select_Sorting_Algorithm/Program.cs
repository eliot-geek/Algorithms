namespace _05_Select_Sorting_Algorithm
{
    internal class Program
    {
        public static void Sort(int[] arrays)
        {
            int length = arrays.Length - 1;
            int minIndex;   // Save the index of the selected minimum

            for (int i = 0; i < length; i++)
            {
                minIndex = i;
                int minValue = arrays[minIndex];
                for (int j = i; j < length; j++)
                {
                    // Minimum exchange with minIndex
                    if (minValue > arrays[j + 1])
                    {
                        minValue = arrays[j + 1];
                        minIndex = j + 1;
                    }
                }
                if (i != minIndex)
                {
                    int temp = arrays[i];
                    arrays[i] = arrays[minIndex];
                    arrays[minIndex] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            // Select Sorting Algorithm: Sorts an array by repeatedly finding the minimum element from unsorted part and putting it at the beginning.
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
