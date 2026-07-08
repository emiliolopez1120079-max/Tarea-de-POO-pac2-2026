using Microsoft.EntityFrameworkCore;
using Sales.API.Entities;

namespace Sale.API.DataBase
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CategoryEntity> Categories {set; get;}
    }
}