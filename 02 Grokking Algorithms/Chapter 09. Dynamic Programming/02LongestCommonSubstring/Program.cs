namespace _02LongestCommonSubstring
{
    internal class Program
    {
        /// <summary>
        /// Calculate the dynamic programming table
        /// </summary>
        /// <param name="blue">The first sequence of characters.</param>
        /// <param name="clues">The second sequence of characters.</param>
        /// <returns>A 2D array representing the dynamic programming table.</returns>
        static int[,] CalculateDPTable(char[] blue, char[] clues)
        {
            int[,] dpTable = new int[blue.Length + 1, clues.Length + 1];
            for (int i = 1; i <= blue.Length; i++)
            {
                for (int j = 1; j <= clues.Length; j++)
                {
                    if (clues[j - 1] == blue[i - 1])
                    {
                        dpTable[i, j] = dpTable[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dpTable[i, j] = 0;
                    }
                }
            }
            return dpTable;
        }


        /// <summary>
        /// Print the dynamic programming table to the console.
        /// </summary>
        /// <param name="dpTable">The 2D array representing the dynamic programming table.</param>
        static void PrintDPTable(int[,] dpTable)
        {
            Console.WriteLine("DP Grid/Table:\n");
            for (int i = 1; i < dpTable.GetLength(0); i++)
            {
                for (int j = 1; j < dpTable.GetLength(1); j++)
                {
                    Console.Write(dpTable[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Find the length of the longest common substring using the dynamic programming table.
        /// </summary>
        /// <param name="blueLength">Length of the first sequence of characters.</param>
        /// <param name="cluesLength">Length of the second sequence of characters.</param>
        /// <param name="dpTable">The dynamic programming table storing lengths of common substrings.</param>
        /// <returns>The length of the longest common substring.</returns>
        static int FindMaxLength(int blueLength, int cluesLength, int[,] dpTable)
        {
            int maxLength = 0;
            for (int i = 0; i <= blueLength; i++)
            {
                for (int j = 0; j <= cluesLength; j++)
                {
                    if (dpTable[i, j] > maxLength)
                    {
                        maxLength = dpTable[i, j];
                    }
                }
            }
            return maxLength;
        }

        static void Main(string[] args)
        {
            // Input sequences
            char[] dpTableBlue = { 'b', 'l', 'u', 'e' };
            char[] dpTableClues = { 'c', 'l', 'u', 'e', 's' };

            // Create a 2D array to store the lengths of common substrings
            int[,] dpTable = CalculateDPTable(dpTableBlue, dpTableClues);

            // Print the DP table
            PrintDPTable(dpTable);

            // Find the length of the longest common substring
            int maxLength = FindMaxLength(dpTableBlue.Length, dpTableClues.Length, dpTable);
            Console.WriteLine($"\nLength of LCSubstring: {maxLength} ");
            Console.ReadKey();
        }
    }
}
