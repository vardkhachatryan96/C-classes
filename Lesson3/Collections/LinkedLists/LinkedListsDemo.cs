using System.Collections.Generic;

namespace Collections.LinkedLists
{
    /// <summary>
    /// Linked List demo model
    /// </summary>
    public class LinkedListsDemo
    {
        /// <summary>
        /// Run Linked List Collection demo
        /// </summary>
        public static void Run()
        {
            // create a LinkedList using LinkedList class
            LinkedList<int> linkedList = new LinkedList<int>();

            // LinkedList provides 4 different methods to add nodes 
            linkedList.AddFirst(1);
            linkedList.AddAfter(linkedList.First, 2);
            linkedList.AddBefore(linkedList.Last, 3);
            linkedList.AddLast(4);

            // LinkedList provides 5 different methods to remove nodes 
            linkedList.RemoveFirst();
            linkedList.Remove(2);
            linkedList.Remove(linkedList.Last);
            linkedList.RemoveLast();
            linkedList.Clear();

            // check if node exists in LinkedList
            if (linkedList.Contains(2))
            {
                // contains
            }
        }
    }
}
