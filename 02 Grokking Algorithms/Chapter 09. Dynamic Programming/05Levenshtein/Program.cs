namespace _05Levenshtein
{
    internal class Program
    {
        /// <summary>
        /// Calculates the Levenshtein Distance between two strings.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="target">The target string.</param>
        /// <returns>The Levenshtein Distance between the source and target strings.</returns>
        public static int LevenshteinDistance(string source, string target)
        {
            // Create the dpTable to store intermediate results
            var dpTable = CreateDpTable(source, target);

            // Iterate through the strings to fill in the dpTable
            for (int i = 1; i <= source.Length; i++)
            {
                for (int j = 1; j <= target.Length; j++)
                {
                    // Calculate the minimum of the three possible operations: insertion, deletion, and substitution
                    dpTable[i, j] = Math.Min(dpTable[i, j - 1] + 1, 
                        Math.Min(dpTable[i - 1, j] + 1,
                        dpTable[i - 1, j - 1] + (source[i - 1] != target[j - 1] ? 1 : 0)));
                }
            }

            // Return the final result from the bottom-right corner of the dpTable
            return dpTable[source.Length, target.Length];
        }

        /// <summary>
        /// Creates and initializes the dynamic programming table for Levenshtein Distance calculation.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="target">The target string.</param>
        /// <returns>The initialized dynamic programming table.</returns>
        private static int[,] CreateDpTable(string source, string target)
        {
            // Create a dpTable with dimensions based on the lengths of the input strings
            var dpTable = new int[source.Length + 1, target.Length + 1];

            // Ensure source is longer or equal to target
            if (target.Length < source.Length)
            {
                // Swap source and target if target is longer
                (source, target) = (target, source);
            }

            // Initialize the first row and column of the dpTable
            for (int i = 0; i <= source.Length; i++)
            {
                dpTable[i, 0] = i;

                // Initialize the column only if it fits within the length of the target
                if (i <= target.Length)
                {
                    dpTable[0, i] = i;
                }
            }

            // Return the initialized dpTable
            return dpTable;
        }

        static void Main(string[] args)
        {
            string source = "kitten";
            string target = "sitting";
            int distance = LevenshteinDistance(source, target);
            Console.WriteLine($"Levenshtein Distance between '{source}' and '{target}': {distance}");
        }
    }
}

/* The Levenshtein Distance algorithm, also known as the Edit Distance, is a dynamic programming algorithm that calculates the minimum number of single-character edits 
 * (insertions, deletions, or substitutions) required to transform one string into another. It's named after the Soviet mathematician Vladimir Levenshtein, who introduced the concept in 1965 
 * Initialization   -   Iteration   -   Result 
 
kitten (source) → sitting (target)

  |   | s | i | t | t | i | n | g |
--+---+---+---+---+---+---+---+---+
  | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 |
--+---+---+---+---+---+---+---+---+
k | 1 | 1 | 2 | 3 | 4 | 5 | 6 | 7 |
--+---+---+---+---+---+---+---+---+
i | 2 | 2 | 1 | 2 | 3 | 4 | 5 | 6 |
--+---+---+---+---+---+---+---+---+
t | 3 | 3 | 2 | 1 | 2 | 3 | 4 | 5 |
--+---+---+---+---+---+---+---+---+
t | 4 | 4 | 3 | 2 | 1 | 2 | 3 | 4 |
--+---+---+---+---+---+---+---+---+
e | 5 | 5 | 4 | 3 | 2 | 2 | 3 | 4 |
--+---+---+---+---+---+---+---+---+
n | 6 | 6 | 5 | 4 | 3 | 3 | 2 | 3 |
--+---+---+---+---+---+---+---+---+

The value at the bottom-right corner (6, 7) is 3, so the Levenshtein Distance between "kitten" and "sitting" is 3. 
This means that it takes a minimum of 3 edits to transform "kitten" into "sitting" or vice versa. */