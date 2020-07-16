using System;

namespace Generics
{
    /// <summary>
    /// The start of the program
    /// </summary>
    public class ConsoleHost
    {
        /// <summary>
        /// Run the application
        /// </summary>
        public void Run()
        {
            Console.WriteLine(this.Compare(4, 5));
        }

        private bool Compare(int a, int b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}