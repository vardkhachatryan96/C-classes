using Lesson4.Exceptions;
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
        public Lesson(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// The start date of the lesson
        /// </summary>
        public DateTime StartDate
        {
            get;
            private set;
        }

        /// <summary>
        /// The end date of the lesson
        /// </summary>
        public DateTime EndDate
        {
            get;
            private set;
        }

        /// <summary>
        /// The lesson name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public void SetDate(DateTime startDate, DateTime endDate)
        {
            if (startDate < DateTime.Now)
            {
                throw new LessonDateException("The start date is invalid!");
            }

            this.StartDate = startDate;

            if (endDate < startDate)
            {
                throw new LessonDateException("The end date is invalid!");
            }

            this.EndDate = endDate;
        }
    }
}