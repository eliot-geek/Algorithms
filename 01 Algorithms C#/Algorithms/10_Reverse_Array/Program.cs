namespace _10_Reverse_Array
{
    internal class Program
    {
        public static void ReverseArray(int[] arrays)
        {
            int length = arrays.Length;
            int middle = length / 2;

            for (int i = 0; i <= middle; i++)
            {
                int temp = arrays[i];
                arrays[i] = arrays[length - i - 1];
                arrays[length - i - 1] = temp;
            }
        }

        static void Main(string[] args)
        {
            // Inversion of ordered sequences
            int[] scores = { 50, 60, 70, 80, 90 };
            ReverseArray(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
