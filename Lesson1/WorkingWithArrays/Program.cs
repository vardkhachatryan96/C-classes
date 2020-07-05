using System;

namespace WorkingWithArrays
{
    /// <summary>
    /// The entry point of the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args">The run arguments</param>
        static void Main(string[] args)
        {
            // create array of integers
            var arrayOfIntegers = new int[] { 45, 12, 33 };

            //for (int i = 0; i < arrayOfIntegers.Length; i++)
            //{
            //    arrayOfIntegers[i] = 4;
            //}

            // add values to the array
            arrayOfIntegers[0] = 42;
            arrayOfIntegers[2] = 17;

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.WriteLine(arrayOfIntegers[i]);
            }

            foreach (var item in arrayOfIntegers)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(arrayOfIntegers);
        }
    }
}