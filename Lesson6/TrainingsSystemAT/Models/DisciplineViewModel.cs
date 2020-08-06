using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingsSystemAT.Models
{
    /// <summary>
    /// The discipline model
    /// </summary>
    public class DisciplineViewModel
    {
        /// <summary>
        /// The lecturers collection
        /// </summary>
        private readonly List<LecturerViewModel> Lecturers;

        /// <summary>
        /// The students collection
        /// </summary>
        private readonly List<StudentViewModel> Students;

        /// <summary>
        /// The lessons collection
        /// </summary>
        private readonly List<LessonViewModel> Lessons;

        /// <summary>
        /// Init the discipline
        /// </summary>
        /// <param name="name"></param>
        public DisciplineViewModel(string name)
        {
            this.Name = name;
            this.Students = new List<StudentViewModel>();
            this.Lessons = new List<LessonViewModel>();
            this.Lecturers = new List<LecturerViewModel>();
        }

        /// <summary>
        /// The discipline name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Add lecturer to lecturers list
        /// </summary>
        /// <param name="lecturer"></param>
        public void AddLecturer(LecturerViewModel lecturer)
        {
            this.Lecturers.Add(lecturer);
        }

        /// <summary>
        /// Add lecturers to lecturers list
        /// </summary>
        /// <param name="lecturers"></param>
        public void AddLecturers(List<LecturerViewModel> lecturers)
        {
            this.Lecturers.AddRange(lecturers);
        }

        /// <summary>
        /// Add student to students list
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(StudentViewModel student)
        {
            if (this.Students.Select(s => s.Id).Contains(student.Id))
            {
                Console.WriteLine($"{student.Name} alredy exists in students list");
                return;
            }

            this.Students.Add(student);
        }

        /// <summary>
        /// Add students to students list
        /// </summary>
        /// <param name="students"></param>
        public void AddStudents(List<StudentViewModel> students)
        {
            var noDuplicateStudents = students.Where(w => !this.Students.Select(s => s.Id).Contains(w.Id));

            this.Students.AddRange(noDuplicateStudents);
        }

        /// <summary>
        /// Add lesson to lesson list
        /// </summary>
        /// <param name="lesson"></param>
        public void AddLesson(LessonViewModel lesson)
        {
            if (this.Lecturers.Count == 0)
            {
                Console.WriteLine("There are no any lecturers in discipline!");
                return;
            }

            this.Lessons.Add(lesson);
        }

        /// <summary>
        /// Add lessons to lesson list
        /// </summary>
        /// <param name="lessons"></param>
        public void AddLessons(List<LessonViewModel> lessons)
        {
            if (this.Lecturers.Count == 0)
            {
                Console.WriteLine("There are no any lecturers in discipline!");
                return;
            }

            this.Lessons.AddRange(lessons);
        }

        /// <summary>
        /// Get Lecturers collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LecturerViewModel> GetLecturers()
        {
            return this.Lecturers;
        }

        /// <summary>
        /// Get Students collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StudentViewModel> GetStudents()
        {
            return this.Students;
        }

        /// <summary>
        /// Get Lessons collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LessonViewModel> GetLessons()
        {
            return this.Lessons;
        }
    }
}
