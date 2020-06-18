namespace ClassesAndStructs.Classes.Polimorphism
{
    /// <summary>
    /// Static polimorphism example
    /// </summary>
    public class StaticPolimorphism
    {
        /// <summary>
        /// Add three numbers
        /// </summary>
        /// <param name="num1">The first number</param>
        /// <param name="num2">The second number</param>
        /// <param name="num3">The third number</param>
        /// <returns></returns>
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="num1">The first number</param>
        /// <param name="num2">The second number</param>
        /// <returns></returns>
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
