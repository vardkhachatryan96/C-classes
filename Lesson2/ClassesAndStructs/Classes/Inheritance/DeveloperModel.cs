namespace ClassesAndStructs.Classes.Inheritance
{
    /// <summary>
    /// Developer model
    /// </summary>
    public class DeveloperModel : PersonModelBase
    {
        /// <summary>
        /// Describe job responsibilities
        /// </summary>
        public override void JobResponsibilities()
        {
            System.Console.WriteLine("Developer responsibilities");
        }
    }
}
