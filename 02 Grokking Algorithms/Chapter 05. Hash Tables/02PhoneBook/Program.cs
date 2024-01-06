namespace _02PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using hash tables for lookups
            // Create a mapping from one thing to another thing - Look something up

            Dictionary<string, uint> phonebook = new Dictionary<string, uint>();
            phonebook["Jenny"] = 867405869;
            phonebook["Emergency"] = 911;
            Console.WriteLine(phonebook["Jenny"]);
        }
    }
}
