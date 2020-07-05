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
            for (int i = 0; i < 1000; i++)
            {
                if (i == 500)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            var a = 0;
            while (a < 10)
            {
                Console.WriteLine("smth");
            }
        }
    }
}