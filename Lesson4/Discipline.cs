using Lesson4.Exceptions;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace TrainingsSystem
{
    /// <summary>
    /// The discipline model
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// The lecturers collection
        /// </summary>
        private readonly List<Lecturer> Lecturers;

        /// <summary>
        /// The students collection
        /// </summary>
        private readonly List<Student> Students;

        /// <summary>
        /// The lessons collection
        /// </summary>
        private readonly List<Lesson> Lessons;

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
        /// Add student to lecturer list
        /// </summary>
        /// <param name="lecturer"></param>
        public void AddLecturer(Lecturer lecturer)
        {
            this.Lecturers.Add(lecturer);
        }

        /// <summary>
        /// Add student to students list
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(Student student)
        {
            foreach (var st in this.Students)
            {
                if (st.Id == student.Id)
                {
                    throw new DuplicateLecturerException(student.Name);
                }
            }

            this.Students.Add(student);
        }        

        /// <summary>
        /// Add student to lesson list
        /// </summary>
        /// <param name="lesson"></param>
        public void AddLesson(Lesson lesson)
        {
            if (this.Lecturers.Count == 0)
            {
                throw new AddingToLessonsCollectionException("There are no any lecturers in discipline!");
            }

            this.Lessons.Add(lesson);
        }

        /// <summary>
        /// Get Lecturers collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Lecturer> GetLecturers()
        {
            return this.Lecturers;
        }

        /// <summary>
        /// Get Students collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetStudents()
        {
            return this.Students;
        }

        /// <summary>
        /// Get Lessons collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Lesson> GetLessons()
        {
            return this.Lessons;
        }
    }
}
