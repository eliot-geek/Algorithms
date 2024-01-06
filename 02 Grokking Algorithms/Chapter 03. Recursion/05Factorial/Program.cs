namespace _05Factorial
{
    internal class Program
    {
        /// <summary>
        /// A recursive function to calculate the factorial of a given number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Factorial(int n)
        {
            if (n == 1) return 1;               // Base case
            else return n * Factorial(n - 1);   // Recursive case
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5)); 
        }
    }
}