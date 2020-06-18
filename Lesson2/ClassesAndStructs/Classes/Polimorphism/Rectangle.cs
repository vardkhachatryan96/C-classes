namespace ClassesAndStructs.Classes.Polimorphism
{
    /// <summary>
    /// The rectangle model
    /// </summary>
    public class Rectangle : Drawing
    {
        /// <summary>
        /// The rectangle height
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// The rectangle width
        /// </summary>
        public double Width { get; set; }
        
        /// <summary>
        /// Create rectangle model
        /// </summary>
        public Rectangle()
        {
            this.Height = 5.3;
            this.Width = 3.4;
        }

        /// <summary>
        /// Get rectangle area
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return this.Height * this.Width;
        }
    }
}
