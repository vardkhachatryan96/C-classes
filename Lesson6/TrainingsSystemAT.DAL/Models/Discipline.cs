using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingsSystemAT.DAL.Models
{
    public class Discipline
    {
        [Key]
        [ForeignKey("DisciplineFK")]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
