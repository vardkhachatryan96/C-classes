using System.Collections.Generic;

namespace Collections.Dictionary
{
    /// <summary>
    /// Type for student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Create student
        /// </summary>
        /// <param name="id">The id of the student</param>
        /// <param name="name">The name of the student</param>
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.TestResults = new Dictionary<string, int>();
        }

        /// <summary>
        /// Id of the student
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the student
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Scores of the student
        /// </summary>
        public Dictionary<string, int> TestResults { get; private set; }

        /// <summary>
        /// Adds test results for student
        /// </summary>
        /// <param name="lessonName">The name of the test</param>
        /// <param name="score">The score for the test</param>
        public void AddTestResult(string testName, int score)
        {
            if (this.TestResults.ContainsKey(testName))
            {
                return;
            }

            this.TestResults.Add(testName, score);
        }
    }
}
