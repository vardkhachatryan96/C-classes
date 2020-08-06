using System.Collections.Generic;

namespace TrainingsSystemAT.BL.Models
{
    /// <summary>
    /// The discipline model
    /// </summary>
    public class DisciplineModel
    {
        /// <summary>
        /// The discpline Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The discipline name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The persons collection
        /// </summary>
        public List<PersonModel> Persons { get; set; }

        /// <summary>
        /// The lessons collection
        /// </summary>
        public List<LessonModel> Lessons { get; set; }   
    }
}
