using static System.Formats.Asn1.AsnWriter;

namespace _06_Linear_Table_Append
{
    internal class Program
    {
        public static int[] Append(int[] array, int value)
        {
            // Create a new array, Length = array.Length + 1
            int[] tempArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = value;
            return tempArray;
        }

        static void Main(string[] args)
        {
            // Add a score 75 to the end of the one-dimensional array scores
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            scores = Append(scores, 75);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
