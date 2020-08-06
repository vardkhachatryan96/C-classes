using System.Collections.Generic;
using System.Linq;
using TrainingsSystemAT.BL.Models;
using TrainingsSystemAT.BL.Types;
using TrainingsSystemAT.DAL.Models;

namespace TrainingsSystemAT.BL.Mappers
{
    public class StudentsMapper
    {
        public IEnumerable<PersonModel> Map(IEnumerable<Person> persons)
        {
            return new List<PersonModel>(persons.Select(s => new PersonModel
            {
                Id = s.Id,
                Name = s.Name,
                Surname = s.Surname,
                Role = (RoleType)s.RoleId
            }));
        }
    }
}
