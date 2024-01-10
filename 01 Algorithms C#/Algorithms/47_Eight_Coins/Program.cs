namespace _47_Eight_Coins
{
    internal class Program
    {
        /// <summary>
        /// Compares the weight of two coins and identifies the counterfeit coin.
        /// </summary>
        /// <param name="coins">Array representing the weights of the coins.</param>
        /// <param name="i">Index of the first coin.</param>
        /// <param name="j">Index of the second coin.</param>
        /// <param name="k">Index of the third coin.</param>
        /// coin[k] true, coin[i]>coin[j]
        public static void Compare(int[] coins, int i, int j, int k)        
        {
            // /coin[i]>coin[j]&&coin[i]>coin[k] –—>coin[i] is a heavy counterfeit coin
            if (coins[i] > coins[k])
            {
                Console.WriteLine("\nCounterfeit currency " + (i + 1) + " is heavier");
            }
            // coin[j] is a light counterfeit coin
            else
            {
                Console.WriteLine("\nCounterfeit currency " + (j + 1) + " is lighter");
            }
        }


        /// <summary>
        /// Detects the counterfeit coin among eight coins.
        /// </summary>
        /// <param name="coins">Array representing the weights of the coins.</param>
        public static void EightCoins(int[] coins)
        {
            // /(a+b+c)==(d+e+f)
            if (coins[0] + coins[1] + coins[2] == coins[3] + coins[4] + coins[5])
            {
                // g>h?(g>a?g:a):(h>a?h:a)
                if (coins[6] > coins[7])
                {
                    Compare(coins, 6, 7, 0);
                }
                // h>g?(h>a?h:a):(g>a?g:a)
                else
                {
                    Compare(coins, 7, 6, 0);
                }
            }
            // (a+b+c)>(d+e+f)
            else if (coins[0] + coins[1] + coins[2] > coins[3] + coins[4] + coins[5])
            {
                // (a+e)==(d+b)
                if (coins[0] + coins[3] == coins[1] + coins[4])
                {
                    Compare(coins, 2, 5, 0);
                }
                // (a+e)>(d+b)
                else if (coins[0] + coins[3] > coins[1] + coins[4])
                {
                    Compare(coins, 0, 4, 1);
                }
                // (a+e)<(d+b)
                if (coins[0] + coins[3] < coins[1] + coins[4])
                {
                    Compare(coins, 1, 3, 0);
                }
            }
            // (a+b+c)<(d+e+f)
            else if (coins[0] + coins[1] + coins[2] < coins[3] + coins[4] + coins[5])
            {
                // (a+e)>(d+b)
                if (coins[0] + coins[3] == coins[1] + coins[4])
                {
                    Compare(coins, 5, 2, 0);
                }
                // (a+e)>(d+b)
                else if (coins[0] + coins[3] > coins[1] + coins[4])
                {
                    Compare(coins, 3, 1, 0);
                }
                // (a+e)<(d+b)
                if (coins[0] + coins[3] < coins[1] + coins[4])
                {
                    Compare(coins, 4, 0, 1);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] coins = new int[8];

            // Initial coin weight is 10
            for (int i = 0; i < 8; i++)
            {
                coins[i] = 10;
            }

            Console.Write("Enter weight of counterfeit currency (larger or smaller than 10): ");
            Random random = new Random();
            coins[random.Next(8)] = Convert.ToInt32(Console.ReadLine());
            EightCoins(coins);

            for (int i = 0; i < 8; i++)
            {
                Console.Write(coins[i] + ", ");
            }
            Console.WriteLine();

        }
    }
}
