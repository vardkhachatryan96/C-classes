using TrainingsSystemAT.DAL.Models.Common;

namespace TrainingsSystemAT.DAL.Models
{
    public class DisciplinePersons : BaseEntity
    {
        public int DisciplineId { get; set; }

        public int PersonId { get; set; }
    }
}
