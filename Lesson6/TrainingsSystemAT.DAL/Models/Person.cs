using TrainingsSystemAT.DAL.Models.Common;

namespace TrainingsSystemAT.DAL.Models
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int RoleId { get; set; }
    }
}
