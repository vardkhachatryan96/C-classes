using System.Collections.Generic;
using TrainingsSystemAT.DAL.Models;

namespace TrainingsSystemAT.DAL.RepositoriesAPI
{
    public interface ILessonsRepository
    {
        IEnumerable<Lesson> GetEarliestLesson();
    }
}
