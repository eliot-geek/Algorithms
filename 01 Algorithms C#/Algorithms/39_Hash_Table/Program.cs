using System.Collections;

namespace _39_Hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable hashtable = new HashTable();
            hashtable.Put("David", "Good Boy Keep Going");
            hashtable.Put("Grace", "Cute Girl Keep Going");
            Console.WriteLine("David => " + hashtable.Get("David"));
            Console.WriteLine("David => " + hashtable.Get("Grace"));
        }
    }
}
