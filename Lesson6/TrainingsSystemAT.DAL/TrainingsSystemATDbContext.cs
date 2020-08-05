using Microsoft.EntityFrameworkCore;
using TrainingsSystemAT.DAL.Models;

namespace TrainingsSystemAT.DAL
{
    public class TrainingsSystemATDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=TrainingsSystemAT;Trusted_Connection=True");
        }

        public virtual DbSet<Person> Persons { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Lesson> Lessons { get; set; }

        public virtual DbSet<Discipline> Disciplines { get; set; }

        public virtual DbSet<DisciplineLessons> DisciplineLessons { get; set; }

        public virtual DbSet<DisciplinePersons> DisciplinePersons { get; set; }
    }
}
