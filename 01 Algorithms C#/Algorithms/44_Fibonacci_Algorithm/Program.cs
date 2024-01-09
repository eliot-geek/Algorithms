namespace _44_Fibonacci_Algorithm
{
    internal class Program
    {
        /// <summary>
        /// Recursive function to calculate the Fibonacci number for a given position.
        /// </summary>
        /// <param name="n">The position in the Fibonacci sequence.</param>
        /// <returns>The Fibonacci number at the given position.</returns>
        public static int Fibanacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibanacci(n - 1) + Fibanacci(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter the number of month : ");
            int number = Convert.ToInt32 (Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i} month : {Fibanacci(i)}");
            }
        }
    }
}
