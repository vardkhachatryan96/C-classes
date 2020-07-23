using Lesson4.Exceptions;
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

            var lesson1 = new Lesson("C# lecture");

            try
            {
                lesson1.SetDate(new DateTime(2020, 7, 24), new DateTime(2020, 8, 23));
            }
            catch (LessonDateException ex)
            {
                Console.WriteLine(ex.Message);
            }

            var lesson2 = new Lesson("C# practice"); //new DateTime(2020, 7, 25), new DateTime(2020, 7, 21));

            var lecturer1 = new Lecturer("lecturerName1", "lecturerSurname1");

            var disciplin = new Discipline("C#");
            //disciplin.AddLecturer(lecturer1);

            try
            {
                disciplin.AddStudent(student1);
                disciplin.AddStudent(student1);
            }
            catch (DuplicateLecturerException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                disciplin.AddLesson(lesson1);
                disciplin.AddLesson(lesson2);
            }
            catch (AddingToLessonsCollectionException ex)
            {
                Console.WriteLine(ex.Message);
            }

            disciplin.GetLecturers().ToList().Clear();
        }
    }
}