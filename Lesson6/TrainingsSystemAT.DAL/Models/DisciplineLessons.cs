using System.ComponentModel.DataAnnotations.Schema;
using TrainingsSystemAT.DAL.Models.Common;

namespace TrainingsSystemAT.DAL.Models
{
    public class DisciplineLessons : BaseEntity
    {
        [ForeignKey("DisciplineFK")]
        public int DisciplineId { get; set; }

        [ForeignKey("LessonFK")]
        public int LessonId { get; set; }
    }
}
