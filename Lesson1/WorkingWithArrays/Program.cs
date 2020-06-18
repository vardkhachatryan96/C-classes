using System;

namespace WorkingWithArrays
{
    /// <summary>
    /// The entry point of the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args">The run arguments</param>
        static void Main(string[] args)
        {
            #region "SimpleArrays"

            // create array of integers
            var arrayOfIntegers = new int[3];

            // add values to the array
            arrayOfIntegers[0] = 42;
            arrayOfIntegers[2] = 17;

            Console.WriteLine(arrayOfIntegers);

            //// another way to create array
            //var arrayInit = new string[4] { "one", "two", "three", "four" };

            //// loop through the array elements and print each one
            //for (int i = 0; i < 4; ++i)
            //{
            //    Console.WriteLine(arrayInit[i]);
            //}

            #endregion

            #region "ObjectArrays"

            //// create array of different types
            //var objectArray = new object[] { 10, false, "C#", new DateTime(2019, 11, 4, 17, 10, 0) };

            //// loop through the array elements and print each one 
            //foreach (var item in objectArray)
            //{
            //    Console.WriteLine($"type: {item.GetType()}, value: {item}");
            //}

            #endregion

            #region "TwoDimArrays"

            //// create two dimensional array
            //var matrix = new int[3, 5];

            //// set all array values to 0
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; ++j)
            //    {
            //        matrix[i, j] = 0;
            //    }
            //}

            //// get array info
            //Console.WriteLine($"Length: {matrix.Length}");
            //Console.WriteLine($"Rank: {matrix.Rank}");
            //Console.WriteLine($"Dim 0: {matrix.GetLength(0)}");
            //Console.WriteLine($"Dim 1: {matrix.GetLength(1)}");

            //// print array elements
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; ++j)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }

            //    Console.WriteLine();
            //}

            //// create two dim array
            //var twoDimArray = new int[3][];

            //// create rows with different length
            //for (int i = 0; i < 3; ++i)
            //{
            //    twoDimArray[i] = new int[2 * i + 1];
            //}

            //// get array info
            //Console.WriteLine($"Length: {twoDimArray.Length}");
            //Console.WriteLine($"Rank: {twoDimArray.Rank}");

            //// print array elements
            //for (int i = 0; i < twoDimArray.Length; ++i)
            //{
            //    for (int j = 0; j < twoDimArray[i].Length; ++j)
            //    {
            //        Console.Write($"{twoDimArray[i][j]} ");
            //    }

            //    Console.WriteLine();
            //}

            #endregion
        }
    }
}