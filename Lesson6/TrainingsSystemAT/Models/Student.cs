using System;

namespace TrainingsSystemAT.Models
{
    /// <summary>
    /// The Student model
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Init the student
        /// </summary>
        /// <param name="name">The student name</param>
        /// <param name="surname">The student surname</param>
        public Student(string name, string surname)
            : base(name, surname)
        {
        }
    }
}
