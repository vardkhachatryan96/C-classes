using System;

namespace ClassesAndStructs.Structs
{
    /// <summary>
    /// Struct example class
    /// </summary>
    public class StructExample
    {
        /// <summary>
        /// The location structure
        /// </summary>
        struct Location
        {
            public int x, y;

            public Location(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        /// <summary>
        /// Run the struct example
        /// </summary>
        public void Run()
        {
            var a = new Location(20, 20);
            var b = a;

            a.x = 100;

            Console.WriteLine(b.x);
        }
    }    
}
