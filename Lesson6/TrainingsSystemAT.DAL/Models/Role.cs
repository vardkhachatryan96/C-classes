using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingsSystemAT.DAL.Models
{
    public class Role
    {
        [Key]
        [ForeignKey("RoleFK")]
        public int Id { get; set; }

        public string RoleName { get; set; }
    }
}
