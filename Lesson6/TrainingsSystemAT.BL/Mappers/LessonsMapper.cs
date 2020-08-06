using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsSystemAT.BL.Models;
using TrainingsSystemAT.DAL.Models;

namespace TrainingsSystemAT.BL.Mappers
{
    public class LessonsMapper
    {
        public IEnumerable<LessonModel> Map(IEnumerable<Lesson> persons)
        {
            return new List<LessonModel>(persons.Select(s => new LessonModel
            {
                Id = s.Id,
                Name = s.Name,
                EndDate = s.EndDate,
                StartDate = s.StartDate
            }));
        }
    }
}
