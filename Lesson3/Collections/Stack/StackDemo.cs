using System;
using System.Collections.Generic;

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
            Console.Write("Please insert the expression want to check: ");
            var input = Console.ReadLine();

            if (CheckParenthesis(input))
            {
                Console.WriteLine("The expression is correct");
            }
            else
            {
                Console.WriteLine("WARN: The expression is incorrect");
            }
        }

        /// <summary>
        /// Check the expression parenthesis
        /// </summary>
        /// <param name="expression">The given string</param>
        /// <returns></returns>
        private static bool CheckParenthesis(string expression)
        {
            // declare an empty character stack
            Stack<char> stack = new Stack<char>();

            foreach (var symb in expression)
            {
                // keep symb in stack if it is a starting parenthesis
                if (symb == '{')
                {
                    stack.Push(symb);
                }

                // remove symb from stack if it is an ending parenthesis
                if (symb.Equals('}'))
                {
                    // case we find an ending parenthesis without a pair 
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            //case of starting parenthesis without a closing parenthesis
            if (stack.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}
