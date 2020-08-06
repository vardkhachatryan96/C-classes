using System.Collections.Generic;
using System.Linq;
using TrainingsSystemAT.BL.Models;
using TrainingsSystemAT.Models;

namespace TrainingsSystemAT.Mappers
{
    public class StudentsMapper
    {
        public static IEnumerable<StudentViewModel> Map(IEnumerable<PersonModel> persons)
        {
            return new List<StudentViewModel>(persons.Select(s => new StudentViewModel(s.Name, s.Surname)
            {
                Id = s.Id
            }));
        }
    }
}
