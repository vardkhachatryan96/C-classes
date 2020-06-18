using System;

namespace ClassesAndStructs.Classes.Polimorphism
{
    /// <summary>
    /// Dynamic Polimorphism example
    /// </summary>
    public partial class DynamicPolimorphism
    {
        /// <summary>
        /// Example for testing 
        /// </summary>
        public void Run()
        {
            Drawing circle = new Circle();
            Console.WriteLine("Circle Area:" + circle.Area());

            Drawing square = new Square();
            Console.WriteLine("Square Area:" + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Rectangle Area:" + rectangle.Area());
        }
    }
}
