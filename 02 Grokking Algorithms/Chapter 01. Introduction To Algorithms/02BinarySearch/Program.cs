using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace _02BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write binary search

            var myList = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine(BinarySearch(myList, 3));  // => 1
            Console.WriteLine(BinarySearch(myList, -1) != null ? BinarySearch(myList, -1).ToString() : "None"); // => None
        }

        // Returns the index of the target element in the array using binary search, or "None" if not found
        // Assumes the array is sorted in ascending order
        // The return type of the method to int? which is a nullable integer means the method can return an int or null.
        public static int? BinarySearch(int[] arr, int item)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == item)
                    return mid;
                else if (arr[mid] < item)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return null;
        }
    }
}
