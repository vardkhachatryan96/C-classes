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

            var lesson1 = new Lesson("C# lecture", new DateTime(2016, 7, 15), new DateTime(2016, 7, 15));
            var lesson2 = new Lesson("C# practice", new DateTime(2020, 7, 25), new DateTime(2020, 7, 21));

            var lecturer1 = new Lecturer("lecturerName1", "lecturerSurname1");

            var disciplin = new Discipline("C#");
            disciplin.AddLecturer(lecturer1);


            disciplin.AddStudent(student1);
            disciplin.AddStudent(student1);

            disciplin.AddLesson(lesson1);
            disciplin.AddLesson(lesson2);

            disciplin.GetLecturers().ToList().Clear();
        }
    }
}