namespace _03LongestCommonSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] dpTableBlue = { 'b', 'l', 'u', 'e' };
            char[] dpTableClues = { 'c', 'l', 'u', 'e', 's' };

            int[,] dpTable = new int[dpTableBlue.Length + 1, dpTableClues.Length + 1];

            for (int i = 1; i <= dpTableBlue.Length; i++)
            {
                for (int j = 1; j <= dpTableClues.Length; j++)
                {
                    if (dpTableClues[j - 1] == dpTableBlue[i - 1])
                    {
                        dpTable[i, j] = dpTable[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dpTable[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("DP Table:");
            for (int i = 1; i <= dpTableBlue.Length; i++)
            {
                for (int j = 1; j <= dpTableClues.Length; j++)
                {
                    Console.Write(dpTable[i, j] + " ");
                }
                Console.WriteLine();
            }

            int maxLength = 0;
            for (int i = 0; i <= dpTableBlue.Length; i++)
            {
                for (int j = 0; j <= dpTableClues.Length; j++)
                {
                    if (dpTable[i, j] > maxLength)
                    {
                        maxLength = dpTable[i, j];
                    }
                }
            }
            Console.WriteLine($"Length of LCSubstring: {maxLength}");
        }
    }
}
