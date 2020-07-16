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
            while (true)
            {
                Console.Write("Please insert the expression want to check: ");
                var input = Console.ReadLine();

                if (input.Equals("q"))
                {
                    break;
                }

                if (CheckParenthesis(input))
                {
                    Console.WriteLine("The expression is correct.");
                }
                else
                {
                    Console.WriteLine("The expression is incorrect.");
                }
            }
        }

        private static bool CheckParenthesis(string expression)
        {
            Stack<char> stack = new Stack<char>(expression.Length);

            foreach (var symb in expression)
            {
                if (symb == '(')
                {
                    stack.Push(symb);
                }

                if (symb.Equals(')'))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}
