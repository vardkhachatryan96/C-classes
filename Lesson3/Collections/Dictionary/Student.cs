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
        }

        /// <summary>
        /// Id of the student
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Name of the student
        /// </summary>
        public string Name { get; set; }

        
    }
}
