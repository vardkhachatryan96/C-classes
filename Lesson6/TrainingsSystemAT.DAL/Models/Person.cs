using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingsSystemAT.DAL.Models
{
    public class Person
    {
        [Key]
        [ForeignKey("PersonFK")]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        [ForeignKey("RoleFK")]
        public int RoleId { get; set; }
    }
}
