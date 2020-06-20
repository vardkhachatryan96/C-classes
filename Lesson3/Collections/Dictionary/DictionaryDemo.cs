using System;
using System.Collections.Generic;

namespace Collections.Dictionary
{
    /// <summary>
    /// Dictionary Demo model
    /// </summary>
    public class DictionaryDemo
    {
        /// <summary>
        /// Run Dictionary Collection demo
        /// </summary>
        public static void Run()
        {
            // create dictionary
            Dictionary<int, string> EmployeeList = new Dictionary<int, string>();

            // add elements to dictionary
            EmployeeList.Add(1, "Mahesh Chand");
            EmployeeList.Add(2, "Praveen Kumar");
            EmployeeList.Add(3, "Raj Kumar");
            EmployeeList.Add(4, "Nipun Tomar");
            EmployeeList.Add(5, "Dinesh Beniwal");

            // retrieve elements from a dictionary
            foreach (var empl in EmployeeList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", empl.Key, empl.Value);
            }

            // get number of elements in a dictionary
            Console.WriteLine("Count: {0}", EmployeeList.Count);

            // get a dictionary item
            var employee = EmployeeList[3];

            // get the collection of keys of dictionary
            Dictionary<int, string>.KeyCollection keys = EmployeeList.Keys;

            // display keys    
            foreach (var key in keys)
            {
                Console.WriteLine("Key: {0}", key);
            }

            // get the collection of values of dictionary
            Dictionary<int, string>.ValueCollection values = EmployeeList.Values;

            // display values    
            foreach (string value in values)
            {
                Console.WriteLine("Value: {0}", value);
            }

            // remove elements from a dictionary
            EmployeeList.Remove(4);

            // find a Key in a Dictionary
            if (!EmployeeList.ContainsKey(6))
            {
                EmployeeList[6] = "New Person";
            }

            // find a Value in a Dictionary
            if (!EmployeeList.ContainsValue("New Person"))
            {
                Console.WriteLine("Item found");
            }
        }
    }
}
