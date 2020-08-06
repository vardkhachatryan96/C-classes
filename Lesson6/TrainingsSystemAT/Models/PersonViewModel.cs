namespace TrainingsSystemAT.Models
{
    /// <summary>
    /// The Person model
    /// </summary>
    public class PersonViewModel
    {
        /// <summary>
        /// Init the person
        /// </summary>
        /// <param name="name">The person name</param>
        /// <param name="surname">The person surname</param>
        public PersonViewModel(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        /// <summary>
        /// PersonId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The person name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The person surname
        /// </summary>
        public string Surname { get; private set; }
    }
}
