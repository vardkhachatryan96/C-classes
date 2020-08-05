using System.ComponentModel.DataAnnotations;

namespace TrainingsSystemAT.DAL.Models.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
