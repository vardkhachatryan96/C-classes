using System;

namespace ClassesAndStructs.Classes.Polimorphism
{
    /// <summary>
    /// The square model
    /// </summary>
    public class Square : Drawing
    {
        /// <summary>
        /// The square length
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Create square 
        /// </summary>
        public Square()
        {
            this.Length = 6;
        }

        /// <summary>
        /// Get square area
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.Pow(this.Length, 2);
        }
    }
}
