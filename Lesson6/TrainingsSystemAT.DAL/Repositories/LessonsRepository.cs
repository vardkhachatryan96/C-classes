using System.Collections.Generic;
using System.Linq;
using TrainingsSystemAT.DAL.Models;
using TrainingsSystemAT.DAL.RepositoriesAPI;

namespace TrainingsSystemAT.DAL.Repositories
{
    public class LessonsRepository : ILessonsRepository
    {
        public IEnumerable<Lesson> GetEarliestLesson()
        {
            using var context = new TrainingsSystemATDbContext();
            return context.Lessons.Where(w => w.StartDate == context.Lessons.Min(lesson => lesson.StartDate))
                .ToList();
        }
    }
}
