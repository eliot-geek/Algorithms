namespace _07Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            To recap, hashes are good for
            • Modeling relationships from one thing to another thing
            • Filtering out duplicates
            • Caching/memorizing data instead of making your server do work
            
            Collisions - Two keys have been assigned the same slot. This is a problem. 
            If you save the price of a fruit in a slot that already has another fruit, you will overwrite the price of the first one
            Solution - if multiple keys map to the same slot, start a linked list at that slot.

            Performance - In the average case, hash tables take O(1) for everything. O(1) is called constant time.
            It means the time taken will stay the same, regardless of how big the hash table is.
            Simple search takes linear time. Binary search is faster — it takes log time. Looking something up in a hash table takes constant time.
            
            Hash tables are as fast as arrays at searching (getting a value at an index). And they’re as fast as linked lists at inserts and deletes. 
            It’s the best of both worlds! But in the worst case, hash tables are slow at all of those. So it’s important that you don’t hit worst-case performance with hash tables. 
            And to do that, you need to avoid collisions. To avoid collisions, you need A low load factor and A good hash function.

            Load factor - The load factor of a hash table is easy to calculate (Numbers of items in hash tables / total number of slots) 
            Suppose you need to store the price of 100 produce items in your hash table, and your hash table has 100 slots. In the best case, each item will get its own slot.
            his hash table has a load factor of 1. Having a load factor greater than 1 means you have more items than slots in your array. 
            Once the load factor starts to grow, you need to add more slots to your hash table. This is called resizing. The rule of thumb is to make an array that is twice the size.
            With a lower load factor, you’ll have fewer collisions, and your table will perform better. A good rule of thumb is, resize when your load factor is greater than 0.7.

            Recap
            Hash tables are a powerful data structure because they’re so fast and they let you model data in a diferent way

            • You can make a hash table by combining a hash function with an array.
            • Collisions are bad. You need a hash function that minimizes collisions.
            • Hash tables have really fast search, insert, and delete.
            • Hash tables are good for modeling relationships from one item to another item.
            • Once your load factor is greater than .07, it’s time to resize your hash table.
            • Hash tables are used for caching data (for example, with a web server).
            • Hash tables are great for catching duplicates.

            */

            Console.WriteLine("Hello, World!");
        }
    }
}
