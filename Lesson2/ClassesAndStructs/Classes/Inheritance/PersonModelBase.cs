namespace ClassesAndStructs.Classes.Inheritance
{
    /// <summary>
    /// The person base model
    /// </summary>
    public class PersonModelBase
    {
        /// <summary>
        /// The Id of the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The surname of the person
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// The job responsibilities of person
        /// </summary>
        public virtual void JobResponsibilities()
        { 
        }
    }
}
