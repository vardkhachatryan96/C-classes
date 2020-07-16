using System;
using System.Collections.Generic;

namespace Collections.Lists
{
    /// <summary>
    /// List Demo model
    /// </summary>
    public class ListDemo
    {
        /// <summary>
        /// Run List Collection demo
        /// </summary>
        public static void Run()
        {
            // List creation in c#
            // List with default capacity  
            List<int> listExample1 = new List<int>();
            
            // List with capacity = 5  
            List<string> listExample2 = new List<string>(5);

            // List created from array
            List<string> animalsList = new List<string>(new string[]{ "Cow", "Camel", "Elephant" });

            // Add items to list in C#
            listExample1.Add(55);
            listExample1.Add(21);
            listExample1.Add(45);
            listExample1.Add(11);
            listExample1.Add(89);

            string[] animals = { "Dog", "Cat"};
            animalsList.AddRange(animals);

            // List of string  
            listExample2.Add("Mahesh Chand");
            listExample2.Add("Chris Love");
            listExample2.Add("Allen O'neill");
            listExample2.Add("Naveen Sharma");
            listExample2.Add("Monica Rathbun");
            listExample2.Add("David McCarter");

            // how to insert elements at a position in a C# List
            listExample2.Insert(3, "Bill Author");

            // Insert array at position 2  
            animalsList.InsertRange(1, animals);

            // how to read a C# List items
            foreach (var item in listExample2)
            {
                Console.WriteLine(item);
            }

            // How to remove items from a C# List
            // Remove an item  
            listExample2.Remove("New Author1");

            // Remove 3rd item  
            listExample2.RemoveAt(3);

            // Remove a range  
            listExample2.RemoveRange(3, 2);

            // Remove all items  
            listExample2.Clear();

            // how to find an element in a C# List
            int idx = listExample2.IndexOf("Naveen Sharma");
            if (idx > 0)
            {
                Console.WriteLine($"Item index in List is: {idx}");
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            // how to sort a C# List elements
            listExample2.Sort();

            //Console.WriteLine("Capacity Is: " + listExample1.Capacity);

            //listExample1.Add(1);
            //Console.WriteLine("Capacity Is: " + listExample1.Capacity);

            //listExample1.Add(2);
            //listExample1.Add(3);
            //listExample1.Add(4);
            //listExample1.Add(5);
            //Console.WriteLine("Capacity Is: " + listExample1.Capacity);
        }
    }
}
