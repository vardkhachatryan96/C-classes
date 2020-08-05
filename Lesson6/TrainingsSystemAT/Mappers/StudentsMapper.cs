using System.Collections.Generic;
using System.Linq;
using TrainingsSystemAT.Models;

namespace TrainingsSystemAT.Mappers
{
    public class StudentsMapper
    {
        public static IEnumerable<Student> Map(IEnumerable<DAL.Models.Person> persons)
        {
            return new List<Student>(persons.Select(s => new Student(s.Name, s.Surname)
            {
                Id = s.Id
            }));
        }
    }
}
