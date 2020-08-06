using System.Collections.Generic;
using System.Linq;
using TrainingsSystemAT.BL.Models;
using TrainingsSystemAT.Models;

namespace TrainingsSystemAT.Mappers
{
    public class LessonsMapper
    {
        public IEnumerable<LessonViewModel> Map(IEnumerable<LessonModel> persons)
        {
            return new List<LessonViewModel>(persons.Select(s => 
                                                    new LessonViewModel(s.Name, s.StartDate, s.EndDate)));
        }
    }
}
