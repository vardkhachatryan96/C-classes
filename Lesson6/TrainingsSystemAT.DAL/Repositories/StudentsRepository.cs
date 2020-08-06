using System.Collections.Generic;
using System.Linq;
using TrainingsSystemAT.DAL.Models;
using TrainingsSystemAT.DAL.RepositoriesAPI;

namespace TrainingsSystemAT.DAL.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        public IEnumerable<Person> GetAllPersonsByDisciplineId(int disciplineId, int roleId)
        {
            using var context = new TrainingsSystemATDbContext();
            return context.Persons.Where(w=>w.RoleId == roleId)
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
