using System;

namespace ClassesAndStructs.Classes.Polimorphism
{
    /// <summary>
    /// The circle model
    /// </summary>
    public class Circle : Drawing
    {
        /// <summary>
        /// The circle radius
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Create circle
        /// </summary>
        public Circle()
        {
            this.Radius = 5;
        }

        /// <summary>
        /// Get circle area
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return 3.14 * Math.Pow(this.Radius, 2);
        }
    }
}
