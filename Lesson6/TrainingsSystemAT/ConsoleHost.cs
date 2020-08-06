using System;
using System.Collections.Generic;
using TrainingsSystemAT.BL.Services;
using TrainingsSystemAT.BL.Types;
using TrainingsSystemAT.Controllers;
using TrainingsSystemAT.Models;

namespace TrainingsSystemAT
{
    internal class ConsoleHost
    {
        private readonly StudentsController _studentsController;

        public ConsoleHost()
        {
            _studentsController = new StudentsController();
        }

        internal void Run()
        {
            // init some data
            InitService.Init();

            //1. The count of all students.
            var allStudentsCount = this.GetAllStudentsCount();
            Console.WriteLine($"All students count is {allStudentsCount}");

            //2. The names of students for a specific discipline.
            Console.WriteLine();
            Console.WriteLine("*******English students*******");
            var englishStudentsList = this.GetAllStudentsByDisciplineName(DisciplineType.English);
            foreach (var student in englishStudentsList)
            {
                Console.WriteLine($"{student.Name} {student.Surname}");
            }

            Console.WriteLine();
            Console.WriteLine("*******C# students*******");
            var cSharpStudentsList = this.GetAllStudentsByDisciplineName(DisciplineType.CSharp);
            foreach (var student in cSharpStudentsList)
            {
                Console.WriteLine($"{student.Name} {student.Surname}");
            }

            //3. The names of students for a discipline which has the maximum number of students.
            //4. The lesson with the earliest start date.
            //5. The name of the discipline with the lesson which has the earliest start date.
            //6. The names of lecturers which teach the discipline which has the maximum number of students.
            //7. The name of the student who participates in the maximum number of disciplines.
            //8. The pairs of student name and discipline name(students are assigned to discipline).
            //9. The names of disciplines sorted by the number of students assigned to the discipline.
            //10. The names of all students which age is less than 30.
        }

        private IEnumerable<StudentViewModel> GetAllStudentsByDisciplineName(DisciplineType discipline)
        {
            return this._studentsController.GetAllStudentsByDisciplineName(discipline);
        }

        private int GetAllStudentsCount()
        {
            return this._studentsController.GetAllStudentsCount();
        }
    }
}