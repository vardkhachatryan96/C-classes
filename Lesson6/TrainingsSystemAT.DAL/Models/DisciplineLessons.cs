using TrainingsSystemAT.DAL.Models.Common;

namespace TrainingsSystemAT.DAL.Models
{
    public class DisciplineLessons : BaseEntity
    {
        public int DisciplineId { get; set; }

        public int LessonId { get; set; }
    }
}
