namespace _30_Recursive_Algorithm
{
    internal class Program
    {
        /// <summary>
        /// Recursive method to calculate the factorial of a number.
        /// </summary>
        /// <param name="n">The number for which the factorial is calculated.</param>
        /// <returns>The factorial of the given number.</returns>
        public static long Factorial(int n)
        {
            // Base case: factorial of 1 is 1
            if (n == 1) 
            {
                return 1;
            }
            else
            {
                // Recursive case: factorial(n) = factorial(n-1) * n
                return Factorial(n - 1) * n;
            }
        }

        static void Main(string[] args)
        {
            int n = 5;
            long factorial = Factorial(n);
            Console.Write("The Factorial of 5 is : " + factorial);
            Console.WriteLine();
        }
    }
}
