using System;

namespace SelectionStatements
{
    /// <summary>
    /// The start of the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point method
        /// </summary>
        /// <param name="args">The run arguments</param>
        static void Main(string[] args)
        {
            // get input from console
            var input = Console.ReadLine();

            var check = false;

            // check input value
            if (input == "Hi")
            {
                check = true;
            }

            if (check)
                check = false;

            if (check)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("You should say hi first :)");
            }

            switch (input)
            {
                case "hhh":
                    Console.WriteLine("case hhh");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }
    }
}
