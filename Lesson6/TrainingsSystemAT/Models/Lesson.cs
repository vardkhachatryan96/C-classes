using System;

namespace TrainingsSystemAT.Models
{
    /// <summary>
    /// The Lesson model
    /// </summary>
    public class Lesson
    {
        /// <summary>
        /// Create a lesson instance
        /// </summary>
        /// <param name="name">The lesson name</param>
        /// <param name="startDate">The lesson start date</param>
        public Lesson(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Create a lesson instance
        /// </summary>
        /// <param name="name">The lesson name</param>
        /// <param name="startDate">The lesson start date</param>
        public Lesson(string name, DateTime startDate, DateTime endDate) : this(name)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// The start date of the lesson
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// The end date of the lesson
        /// </summary>
        public DateTime EndDate { get; private set; }

        /// <summary>
        /// The lesson name
        /// </summary>
        public string Name { get; private set; }
    }
}