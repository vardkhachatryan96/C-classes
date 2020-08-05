using System;
using TrainingsSystemAT.DAL.Models.Common;

namespace TrainingsSystemAT.DAL.Models
{
    public class Lesson : BaseEntity
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
