namespace _02_Maximum_Value
{
    internal class Program
    {
        public static int Maximum(int[] arrays)
        {
            // Maximum initialization value is 0
            for (int i = 0; i < arrays.Length - 1; i++)
            {
                if (arrays[i] > arrays[i + 1])
                {
                    int temp = arrays[i];
                    arrays[i] = arrays[i + 1];
                    arrays[i + 1] = temp;
                }
            }
            int maxValue = arrays[arrays.Length - 1];
            return maxValue;
        }

        static void Main(string[] args)
        {
            // Maximum of Integer Sequences
            int[] scores = { 60, 50, 95, 80, 70 };
            int maxValue = Maximum(scores);
            Console.WriteLine($"Maximum Value : {maxValue}");
        }
    }
}
