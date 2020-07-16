namespace Generics
{
    /// <summary>
    /// The start of the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point method
        /// </summary>
        /// <param name="args">The run arguments</param>
        static void Main(string[] args)
        {
            // create host
            var host = new ConsoleHost();

            // run
            host.Run();
        }
    }
}
