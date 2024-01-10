namespace _48_Knapsack_Problem
{
    /// <summary>
    /// Represents the solution for the Knapsack Problem using dynamic programming.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Maximum size of the knapsack.
        /// </summary>
        public const int MaxSize = 8;

        /// <summary>
        /// Minimum size of the knapsack.
        /// </summary>
        public const int MinSize = 1;

        static void Main(string[] args)
        {
            // Arrays to store information about items and their values
            int[] item = new int[MaxSize + 1];
            int[] value = new int[MaxSize + 1];

            // Array of Fruit objects representing items to be placed in the knapsack
            Fruit[] fruits =
            {
                new Fruit("Plum", 4, 4500),
                new Fruit("Apple", 5, 5700),
                new Fruit("Orange", 2, 2250),
                new Fruit("Mango", 1, 1100),
                new Fruit("Melon", 6, 6700)
            };

            // Dynamic programming approach to solve the knapsack problem
            for (int i = 0; i < fruits.Length; i++)
            {
                for (int j = fruits[i].getSize(); j <= MaxSize; j++)
                {
                    // Calculate the remaining space in the knapsack after including the current fruit
                    int remainingSpace = j - fruits[i].getSize();

                    // Calculate the total value of the knapsack if the current fruit is included
                    int newValue = value[remainingSpace] + fruits[i].getPrice();

                    if (newValue > value[j])
                    {
                        // Update values if a better solution is found
                        value[j] = newValue;

                        // Mark the current item as included in the knapsack
                        item[j] = i;
                    }
                }
            }

            Console.WriteLine("Item \tPrice\n");

            // Display the items included in the knapsack along with their prices
            for (int i = MaxSize; i >= MinSize; i = i - fruits[item[i]].getSize())
            {
                Console.WriteLine(fruits[item[i]].getName() + "\t" + fruits[item[i]].getPrice());
            }

            Console.WriteLine("\nTotal \t" + value[MaxSize]);
        }
    }
}
