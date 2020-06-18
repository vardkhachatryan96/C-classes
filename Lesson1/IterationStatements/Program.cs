using System;

namespace IterationStatements
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
            // print numbers from 0 to 4
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // create number
            var number = 0;

            // print number while it is less than 0
            while (number < 5)
            {
                Console.WriteLine(number);

                number++; // same as number = number + 1
            }

            do
            {
                Console.WriteLine(number);

                number++;

            } while (number < 5);
        }
    }
}