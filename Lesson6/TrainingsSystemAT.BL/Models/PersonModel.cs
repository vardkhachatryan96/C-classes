using TrainingsSystemAT.BL.Types;

namespace TrainingsSystemAT.BL.Models
{
    /// <summary>
    /// The Person model
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// PersonId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The person name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The person surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// The person role
        /// </summary>
        public RoleType Role { get; set; }
    }
}
