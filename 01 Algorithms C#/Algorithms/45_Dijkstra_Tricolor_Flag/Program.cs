namespace _45_Dijkstra_Tricolor_Flag
{
    internal class Program
    {
        /// <summary>
        /// Sorts an array of flags with colors red, white, and blue using the Dutch National Flag algorithm.
        /// </summary>
        /// <param name="flags">Array of flags to be sorted.</param>
        static int DutchNationalFlag(char[] flags)
        {
            int b = 0;                  // Index for blue flag
            int w = 0;                  // Index for white flag
            int r = flags.Length - 1;   // Index for red flag

            int count = 0;

            while (w <= r)
            {
                switch (flags[w])
                {
                    case 'b':
                        Swap(flags, w, b);
                        b++;
                        w++;
                        count++;
                        break;
                    case 'w':
                        w++;
                        break;
                    case 'r':
                        Swap(flags, w, r);
                        r--;
                        count++;
                        break;
                }
            }
            return count;
        }

        /// <summary>
        /// Swaps two elements in an array.
        /// </summary>
        /// <param name="flags">Array containing the elements to be swapped.</param>
        /// <param name="i">Index of the first element.</param>
        /// <param name="j">Index of the second element.</param>
        static void Swap(char[] flags, int i, int j)
        {
            char temp = flags[i];
            flags[i] = flags[j];
            flags[j] = temp;
        }


        static void Main(string[] args)
        {
            char[] flags1 = { 'r', 'w', 'b', 'r', 'w', 'b', 'r', 'w' };
            //char[] flags1 = { 'r', 'b', 'w', 'b', 'r', 'w' };
            Console.WriteLine("Before sorting:");
            Console.WriteLine(string.Join(" ", flags1));

            int count1 = DutchNationalFlag(flags1);
            
            Console.WriteLine("After sorting:");
            Console.WriteLine(string.Join(" ", flags1));
            
            Console.Write("The total exchange count : " + count1);
            Console.WriteLine("\n");


            char[] flags = { 'r', 'w', 'b', 'r', 'w', 'b', 'r', 'w' };
            //char[] flags = { 'r', 'b', 'w', 'b', 'r', 'w' };

            int b = 0;
            int w = 0;
            int r = flags.Length - 1;

            int count = 0;

            while (w <= r)
            {
                if (flags[w] == 'w')
                {
                    w++;
                } 
                else if (flags[w] == 'b') 
                {
                    char temp = flags[w];
                    flags[w] = flags[b];
                    flags[b] = temp;
                    w++;
                    b++;
                    count++;
                }
                else if (flags[w] == 'r')
                {
                    char m = flags[w];
                    flags[w] = flags[r];
                    flags[r] = m;
                    r--;
                    count++;
                }
            }

            Console.WriteLine("\nAfter sorting (another way):");
            for (int i = 0; i < flags.Length; i++)
            {
                Console.Write(flags[i] + " ");
            }
            Console.Write("\nThe total exchange count : " + count);
            Console.WriteLine();
        }
    }
}
