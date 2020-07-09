using System;

namespace TrainingsSystem
{
    public class Lesson
    {
        private readonly DateTime startDate;
        
        public string Name { get; private set; }

        public DateTime StartDate { get { return this.startDate; } }

        public Lesson(string name, DateTime startDate)
        {
            this.Name = name;
            this.startDate = startDate;
        }
    }
}