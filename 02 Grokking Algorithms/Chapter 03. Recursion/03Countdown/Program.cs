namespace _03Countdown
{
    internal class Program
    {
        /// <summary>
        /// This function takes an integer i as its parameter and counts down from i to 1 recursively
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static int Countdown(int i)
        {
            if (i <= 0) return 0;       // Base case (without this case, the code will run forever)
            else Console.WriteLine(i);
            return Countdown(i - 1);    // Recursive case
        }

        static void Main(string[] args)
        {
            Countdown(15);
        }
    }
}