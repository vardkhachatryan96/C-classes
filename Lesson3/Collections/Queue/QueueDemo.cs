using System;
using System.Collections.Generic;
using System.Linq;

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
            // create queue
            string[] courses = { "MCA", "MBA", "BCA", "BBA", "BTech", "MTech" };
            Queue<string> queue = new Queue<string>(courses);

            Console.WriteLine($"There are {courses.Count()} elements in queue");

            // the Queue.Enqueue method adds an object to the end of the Queue<T>
            Queue<string> queue1 = new Queue<string>();
            
            // add elemets 
            queue1.Enqueue("MCA");
            queue1.Enqueue("MBA");
            queue1.Enqueue("BCA");
            queue1.Enqueue("BBA");
            
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }

            // the Queue.Dequeue() method removes and returns the object at the beginning of the Queue<T>
            Queue<string> queue2 = new Queue<string>();

            // add items to queue
            queue2.Enqueue("MCA");
            queue2.Enqueue("MBA");
            queue2.Enqueue("BCA");
            queue2.Enqueue("BBA");

            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }

            queue2.Dequeue(); //Removes the first element that enter in the queue here the first element is MCA  
            queue2.Dequeue(); //Removes MBA  

            Console.WriteLine("After removal the elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }

            // the Queue.Clear() method removes all objects from theQueue<T>
            queue1.Clear();

            // the Queue.Peek method returns the object at the beginning of the Queue<T> without removing it
            Queue<string> queue3 = new Queue<string>();
            
            // add items to queue
            queue3.Enqueue("MCA");
            queue3.Enqueue("MBA");
            queue3.Enqueue("BCA");
            queue3.Enqueue("BBA");

            Console.WriteLine("Peek the first item from the queue is:" + queue3.Peek());

            queue3.Dequeue();

            Console.WriteLine("Peek the next item from the queue is:" + queue3.Peek());
        }
    }
}
