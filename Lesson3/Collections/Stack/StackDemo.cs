using System;

namespace Collections.Stack
{
    /// <summary>
    /// Stack demo model
    /// </summary>
    public class StackDemo
    {
        /// <summary>
        /// Run Stack Collection demo
        /// </summary>
        public static void Run()
        {
            while (true)
            {
                Console.Write("Please insert the expression want to check: ");
                var input = Console.ReadLine();

                if (input.Equals("q"))
                {
                    break;
                }                
            }
        }        
    }
}
