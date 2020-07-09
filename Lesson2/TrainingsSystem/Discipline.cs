using System.Collections.Generic;

namespace TrainingsSystem
{
    /// <summary>
    /// The discipline model
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Init the discipline
        /// </summary>
        /// <param name="name"></param>
        public Discipline(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Lessons = new List<Lesson>();
            this.Lecturers = new List<Lecturer>();
        }

        /// <summary>
        /// The discipline name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The students collection
        /// </summary>
        public List<Student> Students { get; private set; }

        /// <summary>
        /// The lessons collection
        /// </summary>
        public List<Lesson> Lessons { get; private set; }

        /// <summary>
        /// The lecturers collection
        /// </summary>
        private readonly List<Lecturer> Lecturers;

        /// <summary>
        /// Add student to students list
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public List<Lecturer> GetLecturers()
        {
            return new List<Lecturer> (this.Lecturers);
        }

        /// <summary>
        /// Add student to lecturer list
        /// </summary>
        /// <param name="lecturer"></param>
        public void AddLecturer(Lecturer lecturer)
        {
            this.Lecturers.Add(lecturer);
        }

        /// <summary>
        /// Add student to lesson list
        /// </summary>
        /// <param name="lesson"></param>
        public void AddLesson(Lesson lesson)
        {
            this.Lessons.Add(lesson);
        }
    }
}
