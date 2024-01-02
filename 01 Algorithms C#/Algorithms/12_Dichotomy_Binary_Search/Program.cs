namespace _12_Dichotomy_Binary_Search
{
    internal class Program
    {
        public static int BinarySearch(int[] arrays, int searchValue)
        {
            int low = 0;
            int high = arrays.Length - 1;
            int mid = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (arrays[mid] == searchValue)
                {
                    return mid;
                }
                else if (arrays[mid] < searchValue)
                {
                    low = mid + 1;
                }
                else if (arrays[mid] > searchValue)
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] scores = { 30, 40, 50, 70, 85, 90, 100 };
            int searchValue = 40;
            int position = BinarySearch(scores, searchValue);
            Console.WriteLine(searchValue + " is at position: " + position);
            Console.WriteLine("\n--------------------\n");
            searchValue = 90;
            position = BinarySearch(scores, searchValue);
            Console.WriteLine(searchValue + " is at position: " + position);
            Console.WriteLine();
        }
    }
}
