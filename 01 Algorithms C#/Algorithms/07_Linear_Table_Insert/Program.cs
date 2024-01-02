using System;

namespace _07_Linear_Table_Insert
{
    internal class Program
    {
        public static int[] Insert(int[] array, int score, int insertIndex)
        {
            int[] tempArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < insertIndex)
                {
                    tempArray[i] = array[i];
                }
                else
                {
                    tempArray[i + 1] = array[i];
                }
            }
            tempArray[insertIndex] = score;
            return tempArray;
        }

        static void Main(string[] args)
        {
            // Insert a student’s score anywhere in the one dimensional array scores
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            scores = Insert(scores, 75, 2); ; //Insert 75 into the position: index = 2

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
