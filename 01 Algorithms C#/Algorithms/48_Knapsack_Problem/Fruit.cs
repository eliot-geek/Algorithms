using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_Knapsack_Problem
{
    /// <summary>
    /// Represents a fruit with a name, size, and price.
    /// </summary>
    internal class Fruit
    {
        private String name;
        private int size;
        private int price;

        /// <summary>
        /// Initializes a new instance of the Fruit class.
        /// </summary>
        /// <param name="name">The name of the fruit.</param>
        /// <param name="size">The size of the fruit.</param>
        /// <param name="price">The price of the fruit.</param>
        public Fruit(String name, int size, int price)
        {
            this.name = name;
            this.size = size;
            this.price = price;
        }

        /// <summary>
        /// Gets the name of the fruit.
        /// </summary>
        /// <returns>The name of the fruit.</returns>
        public String getName()
        {
            return name;
        }

        /// <summary>
        /// Gets the price of the fruit.
        /// </summary>
        /// <returns>The price of the fruit.</returns>
        public int getPrice()
        {
            return price;
        }

        /// <summary>
        /// Gets the size of the fruit.
        /// </summary>
        /// <returns>The size of the fruit.</returns>
        public int getSize()
        {
            return size;
        }
    }
}
