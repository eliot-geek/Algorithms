namespace _04LongestCommonSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] dpTableBlue = { 'b', 'l', 'u', 'e' };
            char[] dpTableClues = { 'c', 'l', 'u', 'e', 's' };

            int[,] dpTable = new int[dpTableClues.Length + 1, dpTableBlue.Length + 1];

            // Initialize the DP table with zeros
            for (int i = 0; i <= dpTableClues.Length; i++)
            {
                for (int j = 0; j <= dpTableBlue.Length; j++)
                {
                    dpTable[i, j] = 0;
                }
            }

            // Fill in the dynamic programming table
            for (int i = 1; i <= dpTableClues.Length; i++)
            {
                for (int j = 1; j <= dpTableBlue.Length; j++)
                {
                    if (dpTableClues[i - 1] == dpTableBlue[j - 1])
                    {
                        dpTable[i, j] = dpTable[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dpTable[i, j] = Math.Max(dpTable[i - 1, j], dpTable[i, j - 1]);
                    }
                }
            }

            // Print the DP table
            Console.WriteLine("DP Table:");
            for (int i = 1; i <= dpTableClues.Length; i++)
            {
                for (int j = 1; j <= dpTableBlue.Length; j++)
                {
                    Console.Write(dpTable[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Find the length of the Longest Common Subsequence
            int lcsLength = dpTable[dpTableClues.Length, dpTableBlue.Length];
            Console.WriteLine($"Length of LCSubsequence: {lcsLength}");
        }
    }
}
