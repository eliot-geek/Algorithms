using System.Diagnostics;

namespace _01_Linear_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a one-dimensional array of student scores
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            for (int i = 0; i < scores.Length; i++)
            {
                Debug.Write(scores[i] + " ");
                Console.Write(scores[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
