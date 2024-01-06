namespace _07GreatestCommonDivisor
{
    internal class Program
    {
        /// <summary>
        /// Calculates the greatest common divisor (GCD) of two integers using recursion
        /// </summary>
        /// <param name="FirstNumber"></param>
        /// <param name="SecondNumber"></param>
        /// <returns> It returns the GCD of the two input integers</returns>
        public static int GetGCD2(int FirstNumber, int SecondNumber)
            => SecondNumber == default ? FirstNumber : GetGCD2(SecondNumber, FirstNumber % SecondNumber);


        /// <summary>
        /// Calculates the greatest common divisor (GCD) of two integers using recursion
        /// </summary>
        /// <param name="FirstNumber"></param>
        /// <param name="SecondNumber"></param>
        /// <returns></returns>
        public static int GetGCD(int FirstNumber, int SecondNumber)
        {
            if (SecondNumber == 0) return FirstNumber;
            if (FirstNumber == 0) return SecondNumber;
            else return GetGCD(SecondNumber, FirstNumber % SecondNumber);
        }


        /// <summary>
        /// Calculates the GCD of a list of integers using recursion and the GetGCD method
        /// </summary>
        /// <param name="list">It takes a list of integers</param>
        /// <returns></returns>
        public static int GetGCDList(List<int> list)
        {
            var result = list[0];
            result = GetGCD(result, list.Skip(1).FirstOrDefault());
            return result;
        }

        static void Main(string[] args)
        {
            var list = new List<int> { 32, 696, 40, 50 };
            var GCDList = GetGCDList(list);
            var GCD = GetGCD(640, 1680);

            Console.WriteLine(GCD);
            Console.WriteLine(GCDList);
        }
    }
}