using System.Collections.Generic;
using TrainingsSystemAT.BL.Models;

namespace TrainingsSystemAT.BL.ServicesAPI
{
    public interface ILessonsService
    {
        IEnumerable<LessonModel> GetEarliestLesson();
    }
}
