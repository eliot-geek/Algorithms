namespace _01PriceOfGroceries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hash functions

            Dictionary<string, decimal> book = new Dictionary<string, decimal>();
            book["Apple"] = 0.67m;
            book["Milk"] = 1.49m;
            book["Avocado"] = 1.49m;
            foreach(KeyValuePair<string, decimal> item in book)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }
    }
}
