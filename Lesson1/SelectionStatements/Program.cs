using System;

namespace SelectionStatements
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
            // get input from console
            var input = Console.ReadLine();

            // check input value
            if (input == "Hi")
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("You should say hi first :)");
            }
        }
    }
}
