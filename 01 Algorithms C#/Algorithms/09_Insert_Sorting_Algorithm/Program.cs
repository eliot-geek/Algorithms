using System.Xml.Linq;

namespace _09_Insert_Sorting_Algorithm
{
    internal class Program
    {
        public static void InsertSort(int[] arrays)
        {
            for (int i = 1; i < arrays.Length; i++)
            {
                int insertElement = arrays[i];  // Take unsorted new elements
                int insertPosition = i;         // Inserted position

                for (int j = insertPosition - 1; j >= 0; j--)
                {
                    // If the new element is smaller than the sorted  element, it is shifted to the right
                    if (insertElement < arrays[j])
                    {
                        arrays[j + 1] = arrays[j];
                        insertPosition--;
                    }
                }
                arrays[insertPosition] = insertElement; //Insert the new element
            }
        }

        static void Main(string[] args)
        {
            // Insert Sorting Algorithm
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            InsertSort(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
