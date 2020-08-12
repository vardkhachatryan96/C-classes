using Microsoft.EntityFrameworkCore;
using Lesson7.DAL.Models;

namespace Lesson7.DAL
{
    class OnlineStoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=OnlineStore;Trusted_Connection=True");
        }

        public virtual DbSet<PurchasedOrder> PurchasedOrders { get; set; }
    }
}
