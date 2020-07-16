using System;
using System.Collections.Generic;

namespace Collections.Queue
{
    /// <summary>
    /// Queue Demo model
    /// </summary>
    public class QueueDemo
    {
        /// <summary>
        /// Run Queue Collection demo
        /// </summary>
        public static void Run()
        {
            while (true)
            {
                // get doc name
                var inputDocName = Console.ReadLine();

                if (inputDocName.Equals("q"))
                {
                    break;
                }
            }
        }      
    }
}
