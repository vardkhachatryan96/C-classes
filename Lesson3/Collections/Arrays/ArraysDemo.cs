using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Arrays
{
    /// <summary>
    /// Array Demo model
    /// </summary>
    public class ArraysDemo
    {
        /// <summary>
        /// Run Array Collection demo
        /// </summary>
        public static void Run()
        {
            // create an array
            Array stringArray = Array.CreateInstance(typeof(string), 5);

            // set array item values
            stringArray.SetValue("Mahesh", 0);
            stringArray.SetValue("Raj", 1);
            stringArray.SetValue("Neel", 2);
            stringArray.SetValue("Beniwal", 3);
            stringArray.SetValue("Chand", 4);

            // find an item    
            var name = "Neel";

            // find name index
            int nameIndex = Array.BinarySearch(stringArray, name);

            // check if index exists
            if (nameIndex >= 0)
            {
                Console.WriteLine($"Item was at {nameIndex}th position");
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            // sorting Items in an Array
            Array.Sort(stringArray);

            // reverse an array items
            Array.Reverse(stringArray);

            // clear an array items
            Array.Clear(stringArray, 1, 2);

            // get array size
            var arrSize = stringArray.GetLength(0);
        }
    }
}
