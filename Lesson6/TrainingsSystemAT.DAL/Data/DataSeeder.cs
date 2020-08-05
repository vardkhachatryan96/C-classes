using System;
using System.Collections.Generic;
using System.Linq;
using TrainingsSystemAT.DAL.Models;

namespace TrainingsSystemAT.DAL.Data
{
    public class DataSeeder
    {
        public static void Initialize()
        {
            using var context = new TrainingsSystemATDbContext();
            if (!context.Roles.Any())
            {
                var roles = new List<Role>()
                {
                    new Role { RoleName = "Student"},
                    new Role { RoleName = "Teacher",}
                };
                context.Roles.AddRange(roles);
                context.SaveChanges();
            }

            if (!context.Persons.Any())
            {
                var persons = new List<Person>()
                {
                    new Person { Name = "Paul", Surname = "Evans", RoleId = 2 },
                    new Person { Name = "Paul", Surname = "Flin", RoleId = 2 },
                    new Person { Name = "John", Surname = "Smith", RoleId = 2 },
                    new Person { Name = "Ann", Surname = "Jones", RoleId = 1 },
                    new Person { Name = "Mary", Surname = "Wilson", RoleId = 1 },
                    new Person { Name = "William", Surname = "Jackson", RoleId = 1 },
                    new Person { Name = "Sophia", Surname = "Jackson", RoleId = 1 },
                    new Person { Name = "Alice", Surname = "White", RoleId = 1 },
                    new Person { Name = "Robert", Surname = "Harris", RoleId = 1 }
                };
                context.Persons.AddRange(persons);
                context.SaveChanges();
            }

            if (!context.Lessons.Any())
            {
                var lessons = new List<Lesson>()
                {
                    new Lesson { Name = "English", StartDate = new DateTime(2020, 6, 1), EndDate= new DateTime(2020, 9, 29) },
                    new Lesson { Name = "C# lecture", StartDate = new DateTime(2020, 6, 1), EndDate = new DateTime(2020, 9, 29) },
                    new Lesson { Name = "C# practice", StartDate = new DateTime(2020, 7, 2), EndDate = new DateTime(2020, 10, 3) }
                };
                context.Lessons.AddRange(lessons);
                context.SaveChanges();
            }

            if (!context.Disciplines.Any())
            {
                var disciplines = new List<Discipline>()
                {
                    new Discipline { Name = "English" },
                    new Discipline { Name = "C#"}
                };
                context.Disciplines.AddRange(disciplines);
                context.SaveChanges();
            }

            if (!context.DisciplineLessons.Any())
            {
                var disciplineLessons = new List<DisciplineLessons>()
                {
                    new DisciplineLessons { DisciplineId = 1, LessonId = 1},
                    new DisciplineLessons { DisciplineId = 2, LessonId = 2},
                    new DisciplineLessons { DisciplineId = 2, LessonId = 3}
                };
                context.DisciplineLessons.AddRange(disciplineLessons);
                context.SaveChanges();
            }

            if (!context.DisciplinePersons.Any())
            {
                var disciplinePersons = new List<DisciplinePersons>()
                {
                    // lecturers
                    new DisciplinePersons { DisciplineId = 1, PersonId = 1},
                    new DisciplinePersons { DisciplineId = 2, PersonId = 2},
                    new DisciplinePersons { DisciplineId = 2, PersonId = 3},
                    // students
                    new DisciplinePersons { DisciplineId = 1, PersonId = 4},
                    new DisciplinePersons { DisciplineId = 1, PersonId = 5},
                    new DisciplinePersons { DisciplineId = 1, PersonId = 6},
                    new DisciplinePersons { DisciplineId = 1, PersonId = 7},
                    new DisciplinePersons { DisciplineId = 1, PersonId = 8},
                    new DisciplinePersons { DisciplineId = 1, PersonId = 9},
                    new DisciplinePersons { DisciplineId = 2, PersonId = 5},
                    new DisciplinePersons { DisciplineId = 2, PersonId = 6},
                    new DisciplinePersons { DisciplineId = 2, PersonId = 7},
                    new DisciplinePersons { DisciplineId = 2, PersonId = 8}
                };
                context.DisciplinePersons.AddRange(disciplinePersons);
                context.SaveChanges();
            }
        }
    }
}
