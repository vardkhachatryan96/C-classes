using System.ComponentModel.DataAnnotations.Schema;
using TrainingsSystemAT.DAL.Models.Common;

namespace TrainingsSystemAT.DAL.Models
{
    public class DisciplinePersons : BaseEntity
    {
        [ForeignKey("DisciplineFK")]
        public int DisciplineId { get; set; }

        [ForeignKey("PersonFK")]
        public int PersonId { get; set; }
    }
}
