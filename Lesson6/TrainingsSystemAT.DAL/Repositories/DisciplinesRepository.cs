using System.Collections.Generic;
using TrainingsSystemAT.DAL.Models;
using TrainingsSystemAT.DAL.RepositoriesAPI;

namespace TrainingsSystemAT.DAL.Repositories
{
    public class DisciplinesRepository : IDisciplinesRepository
    {
        public Dictionary<string, List<Person>> GetPersonsPerDiscipline(int roleId)
        {
            using var context = new TrainingsSystemATDbContext();
            //select DisciplinePersons.DisciplineId, Disciplines.Name, Persons.Name, Persons.Surname from DisciplinePersons
            //join Persons
            //on Persons.Id = DisciplinePersons.PersonId
            //join Disciplines
            //on Disciplines.Id = DisciplinePersons.DisciplineId
        }
    }
}
