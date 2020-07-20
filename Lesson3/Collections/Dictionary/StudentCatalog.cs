using System.Collections.Generic;

namespace Collections.Dictionary
{
    /// <summary>
    /// Catalog of the students
    /// </summary>
    public class StudentCatalog
    {
        /// <summary>
        /// List of students
        /// </summary>
        public Dictionary<int, Student> Students { get; private set; }

        /// <summary>
        /// Create students list
        /// </summary>
        public StudentCatalog()
        {
            this.Students = new Dictionary<int, Student>();
        }

        /// <summary>
        /// Add a single student to the catalog.
        /// </summary>
        public void AddStudent(Student student)
        {
            if (student == null || this.Students.ContainsKey(student.Id))
            {
                return;
            }

            this.Students.Add(student.Id, student);
        }

        /// <summary>
        /// Return the student with id
        /// </summary>
        /// <param name="id">The id of the student</param>
        /// <returns></returns>
        public Student GetStudent(int id)
        {
            if (this.Students.TryGetValue(id, out Student student))
            {
                return student;
            }

            return null;
        }

        /// <summary>
        /// Given an id, return the score average for the student with that id.
        /// If no student exists with the given id, return -1.
        /// </summary>
        /// <param name="id">The id of the student</param>
        /// <returns></returns>
        public int GetAverageForStudent(int id)
        {
            if (!this.Students.ContainsKey(id))
            {
                return -1;
            }

            var student = this.Students[id];

            if (student.TestResults.Count < 1)
            {
                return -1;
            }

            var scoresSum = 0;

            foreach (var score in student.TestResults)
            {
                scoresSum += score.Value;
            }

            var average = scoresSum / student.TestResults.Count;

            return average;
        }
    }
}
