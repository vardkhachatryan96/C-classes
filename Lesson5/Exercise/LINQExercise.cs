using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Lesson5.Exercise
{
    /// <summary>
    /// LINQ Exercise model
    /// </summary>
    public class LINQExercise
    {
        /// <summary>
        /// Run LINQ Exercise
        /// </summary>
        public void Run()
        {
            // init temp data
            var disciplines = this.InitDisciplines();

            // Find the count of all students

            // Find the names of students for a discipline which has the maximum number of students

            // Find the name of the discipline with the lesson which has the earliest start date

            // Find the name of the student who participates in the maximum number of disciplines

            // Find the names of disciplines sorted by the number of students assigned to the discipline
        }

        /// <summary>
        /// Create disciplines
        /// </summary>
        /// <returns></returns>
        private List<Discipline> InitDisciplines()
        {
            // create C# students, lecturers and lessons
            var cSharpStudents = this.InitCSharpStudents();
            var cSharpLecturers = this.InitCSharpLecturers();
            var cSharpLessons = this.InitCSharpLessons();

            // create english students, lecturers and lessons
            var englishStudents = this.InitEnglishStudents();
            var englishLecturers = this.InitEnglishLecturers();
            var englishLessons = this.InitEnglishLessons();

            // create C# discipline
            var cSharpDisciplin = new Discipline("C#");
            cSharpDisciplin.AddStudents(cSharpStudents);
            cSharpDisciplin.AddLecturers(cSharpLecturers);
            cSharpDisciplin.AddLessons(cSharpLessons);

            // create English discipline
            var englishDisciplin = new Discipline("English");
            englishDisciplin.AddStudents(englishStudents);
            englishDisciplin.AddLecturers(englishLecturers);
            englishDisciplin.AddLessons(englishLessons);

            return new List<Discipline> { cSharpDisciplin, englishDisciplin };
        }

        /// <summary>
        /// Create C# students
        /// </summary>
        /// <returns></returns>
        private List<Student> InitCSharpStudents()
        {
            return new List<Student>
            {
                new Student("John", "Smith"),
                new Student("Ann", "Jones"),
                new Student("Mary", "Wilson"),
                new Student("William", "Jackson"),
                new Student("Robert", "Harris"),
                new Student("Sophia", "Turner"),
                new Student("Edward", "Wood"),
                new Student("Martha", "Hall"),
                new Student("Joseph", "Thompson"),
                new Student("Chloe", "Brown")
            };
        }

        /// <summary>
        /// Create C# lecturers
        /// </summary>
        /// <returns></returns>
        private List<Lecturer> InitCSharpLecturers()
        {
            return new List<Lecturer>
            {
                new Lecturer("Paul", "Flin"),
                new Lecturer("Elise", "Black")
            };
        }

        /// <summary>
        /// Create C# Lessons
        /// </summary>
        /// <returns></returns>
        private List<Lesson> InitCSharpLessons()
        {
            return new List<Lesson>
            {
                new Lesson("C# lecture", new DateTime(2020, 6, 1), new DateTime(2020, 9, 29)),
                new Lesson("C# practice", new DateTime(2020, 7, 2), new DateTime(2020, 10, 3))
            };
        }

        /// <summary>
        /// Create English students
        /// </summary>
        /// <returns></returns>
        private List<Student> InitEnglishStudents()
        {
            return new List<Student>
            {
                new Student("John", "Smith"),
                new Student("Ann", "Jones"),
                new Student("Alice", "White"),
                new Student("William", "Jackson"),
                new Student("Robert", "Harris"),
                new Student("Sophia", "Turner"),
                new Student("Edward", "Wood"),
                new Student("Martha", "Hall"),
            };
        }

        /// <summary>
        /// Create English lecturers
        /// </summary>
        /// <returns></returns>
        private List<Lecturer> InitEnglishLecturers()
        {
            return new List<Lecturer>
            {
                new Lecturer("Dorothy", "Evans")
            };
        }

        /// <summary>
        /// Create English lessons
        /// </summary>
        /// <returns></returns>
        private List<Lesson> InitEnglishLessons()
        {
            return new List<Lesson>
            {
                new Lesson("English", new DateTime(2020, 6, 1), new DateTime(2020, 9, 29))
            };
        }
    }
}
