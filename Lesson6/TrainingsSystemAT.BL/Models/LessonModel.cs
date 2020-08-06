using System;

namespace TrainingsSystemAT.BL.Models
{
    /// <summary>
    /// The Lesson model
    /// </summary>
    public class LessonModel
    {
        /// <summary>
        /// The lesson id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The lesson name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The start date of the lesson
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of the lesson
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}