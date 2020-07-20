using System;
using System.Collections.Generic;
using UC.Common.Extend;

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

            var myDict = new Dictionary<int, string>();
            var myDict1 = new Dictionary<int, string>();
            myDict.Add(1, "str1");
            myDict.Add(2, "str2");
            myDict1.Add(3, "str3");
            myDict1.Add(4, "str4");

            myDict.Put(4, "str5");
            myDict.PutRange(myDict1);
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