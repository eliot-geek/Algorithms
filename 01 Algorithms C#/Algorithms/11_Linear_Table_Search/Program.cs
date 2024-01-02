namespace _11_Linear_Table_Search
{
    internal class Program
    {
        public static int Search(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            Console.Write("Please enter the value you want to search : ");
            int value = Convert.ToInt32(Console.ReadLine());
            int index = Search(scores, value);

            if (index > 0)
            {
                Console.WriteLine("Found value : " + value + "\nThe index is : " + index);
            }
            else
            {
                Console.WriteLine("The value " + value + " was not found.");
            }
        }
    }
}
