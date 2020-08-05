using System.Collections.Generic;
using System.Linq;
using TrainingsSystemAT.DAL.Models;
using TrainingsSystemAT.DAL.RepositoriesAPI;

namespace TrainingsSystemAT.DAL.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        public IEnumerable<Person> GetAllStudentsByDisciplineName(string disciplineName)
        {
            using var context = new TrainingsSystemATDbContext();
            var disciplineId = context.Disciplines.Where(w => w.Name == disciplineName).Select(s => s.Id).FirstOrDefault();
            return context.Persons.Where(w=>w.RoleId == 1)
                .Join(context.DisciplinePersons.Where(w => w.DisciplineId == disciplineId), person => person.Id,
                      dperson => dperson.PersonId, (person, dperson) => new Person
                      {
                          Name = person.Name,
                          Surname = person.Surname,
                          RoleId = person.RoleId
                      }).ToList();
        }

        public int GetAllStudentsCount()
        {
            using var context = new TrainingsSystemATDbContext();
            return context.Persons.Where(w => w.RoleId == 1).Count();
        }
    }
}
