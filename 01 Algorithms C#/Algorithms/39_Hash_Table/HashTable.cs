using System;

namespace _39_Hash_Table
{
    internal class HashTable
    {
        private const int DefaultCapacity = 4;
        private Node[] buckets;

        /// <summary>
        /// Initializes a new instance of the HashTable class with the default capacity.
        /// </summary>
        public HashTable()
        {
            buckets = new Node[DefaultCapacity];
        }

        /// <summary>
        /// Adds a key-value pair to the hash table.
        /// </summary>
        /// <param name="key">The key of the key-value pair.</param>
        /// <param name="value">The value associated with the key.</param>
        public void Put(object key, object value)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            // Ensure a non-negative index within the bounds of the array
            int hash = key.GetHashCode();
            int index = (hash & 0x7FFFFFFF) % buckets.Length;

            if (index < 0 || index >= buckets.Length)
            {
                throw new InvalidOperationException("Invalid index calculated");
            }

            Node newNode = new Node(key, value, hash, null);
            if (buckets[index] == null)
            {
                buckets[index] = newNode;
            }
            else
            {
                Node current = buckets[index];
                while (current.next != null)
                {
                    if (current.hash == hash && Equals(current.key, key))
                    {
                        current.value = value;
                        return;
                    }
                    current = current.next;
                }

                current.next = newNode;
            }
        }

        /// <summary>
        /// Retrieves the value associated with the specified key from the hash table.
        /// </summary>
        /// <param name="key">The key whose value to retrieve.</param>
        /// <returns>The value associated with the key, or null if the key is not found.</returns>
        public object Get(object key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            int hash = key.GetHashCode();
            int index = (hash & 0x7FFFFFFF) % buckets.Length;

            if (index < 0 || index >= buckets.Length)
            {
                throw new InvalidOperationException("Invalid index calculated");
            }

            // Ensure the array is not null before accessing it
            if (buckets == null)
            {
                throw new InvalidOperationException("Hashtable is not properly initialized");
            }

            Node current = buckets[index];
            while (current != null)
            {
                if (current.hash == hash && Equals(current.key, key))
                {
                    return current.value;
                }
                current = current.next;
            }

            return null;
        }
    }
}
