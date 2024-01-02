namespace _04_Minimum_Value
{
    internal class Program
    {
        public static int Minimum(int[] arrays)
        {
            // The index of the minimum
            int minIndex = 0;
            for (int i = 1; i < arrays.Length; i++)
            {
                if (arrays[minIndex] > arrays[i])
                {
                    minIndex = i;
                }
            }
            return arrays[minIndex];
        }

        static void Main(string[] args)
        {
            // Search the Minimum of Integer Sequences
            int[] scores = { 60, 80, 95, 50, 70 };
            int minValue = Minimum(scores);
            Console.Write($"Minimum Value : {minValue}");
            Console.WriteLine();
        }
    }
}
