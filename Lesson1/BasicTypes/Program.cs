using System;

namespace BasicTypes
{
    /// <summary>
    /// The start of the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args">The run arguments</param>
        static void Main(string[] args)
        {
            // C# basic types
            bool a = true; // bits 1; {0,1} stores true or false values
            byte b = 1; // bits 8; range 0 to 255
            char c = 'y'; // bytes 2; Unicode characters
            float f = 1.1f; // bytes 4; ±1.5 x 10−45 to ±3.4 x 1038  
            double e = 9.1; // bytes 8; ±5.0 × 10−324 to ±1.7 × 10308
            decimal d = 5.4m; // bytes 16; ±1.0 x 10-28 to ±7.9228 x 1028
            short i = 32767;  // bits 16; range - 32768 to 32767
            int g = 1;  // bits 32; range - 2147483648 to 2147483647
            long h = 1;  // bits 64; range - 9223372036854775808 to 9223372036854775807
            string j = "Hi, I am a string"; // Length up to 2 billion bytes 3      

            var x = func();

            dynamic y = 5;
            y = "this is a string";

            Console.WriteLine(y);
        }

        private static string func()
        {
            return "fsdfsd";
        }
    }
}
