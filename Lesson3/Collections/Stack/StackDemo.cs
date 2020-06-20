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
            // create stack 
            Stack<string> stack = new Stack<string>();

            // add elements to stack 
            stack.Push("************");
            stack.Push("MCA");
            stack.Push("MBA");
            stack.Push("BCA");
            stack.Push("BBA");
            stack.Push("***********");
            stack.Push("**Courses**");
            stack.Push("***********");
            
            Console.WriteLine("The elements in the stack are as:");
            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }

            // for remove/or pop the element pop() method is used  
            // the element that inserted in last is remove firstly.  
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine("After removal/or pop the element the stack is as:");
            
            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }
        }
    }
}
