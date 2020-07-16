using System;
using System.Linq;

namespace TrainingsSystem
{
    public class ConsoleHost
    {
        /// <summary>
        /// Run th application
        /// </summary>
        public void Run()
        {
            var student1 = new Student("Name1", "Surname1");

            var lesson1 = new Lesson("C# lecture", DateTime.Now);
            var lesson2 = new Lesson("C# practice", DateTime.Now);

            var lecturer1 = new Lecturer("lecturerName1", "lecturerSurname1");

            var disciplin = new Discipline("C#");

            disciplin.AddStudent(student1);
            
            disciplin.AddLesson(lesson1);
            disciplin.AddLesson(lesson2);

            disciplin.AddLecturer(lecturer1);

            disciplin.GetLecturers().ToList().Clear();
        }
    }
}