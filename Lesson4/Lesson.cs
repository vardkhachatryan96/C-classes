using System;

namespace TrainingsSystem
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
        public Lesson(string name, DateTime startDate, DateTime endDate)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// The start date of the lesson
        /// </summary>
        public DateTime StartDate { get; }

        /// <summary>
        /// The end date of the lesson
        /// </summary>
        public DateTime EndDate { get; }

        /// <summary>
        /// The lesson name
        /// </summary>
        public string Name { get; private set; }
    }
}