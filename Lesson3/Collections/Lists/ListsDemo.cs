using System;
using System.Collections.Generic;

namespace Collections.Lists
{
    /// <summary>
    /// List Demo model
    /// </summary>
    public class ListsDemo
    {
        /// <summary>
        /// Run List Collection demo
        /// </summary>
        public static void Run()
        {
            // how to create List in c#
            // List with default capacity  
            List<int> list = new List<int>();

            // List with capacity = 5  
            List<string> authors = new List<string>(5);

            // List created from array
            string[] animals = { "Cow", "Camel", "Elephant" };
            List<string> animalsList = new List<string>(animals);

            // how to add items to a C# List
            List<int> numberList = new List<int>();
            numberList.Add(32);
            numberList.Add(21);
            numberList.Add(45);
            numberList.Add(11);
            numberList.Add(89);
            // List of string  
            List<string> people = new List<string>(5);
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");

            // Collection of string  
            string[] animalss = { "Cow", "Camel", "Elephant" };

            // Create a List and add a collection  
            List<string> animalssList = new List<string>();
            animalsList.AddRange(animals);

            // how to read a C# List items?
            foreach (var item in authors)
            {
                Console.WriteLine(item);
            }

            // how to insert elements at a position in a C# List
            authors.Insert(3, "Bill Author");

            // Collection of new authors  
            string[] newAuthors = { "New Author1", "New Author2", "New Author3" };

            // Insert array at position 2  
            authors.InsertRange(2, newAuthors);

            // How to remove items from a C# List
            // Remove an item  
            authors.Remove("New Author1");

            // Remove 3rd item  
            authors.RemoveAt(3);

            // Remove a range  
            authors.RemoveRange(3, 2);

            // Remove all items  
            authors.Clear();

            // how to find an element in a C# List
            int idx = authors.IndexOf("Naveen Sharma");
            if (idx > 0)
            {
                Console.WriteLine($"Item index in List is: {idx}");
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            // how to sort a C# List elements
            authors.Sort();
        }
    }
}
