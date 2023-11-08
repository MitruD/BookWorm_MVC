using BookWormWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWormWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //1.Next Package Manager Console: update database - will create a database


        //PMC: add-migration AddCategoryTableToDb => update-database
        public DbSet<Category> Categories { get; set; }


        //Seeding data to db => PMC: add-migration ... => update database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1},
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2},
                new Category { Id = 3, Name = "History", DisplayOrder = 3}
                );
        }
    }
}
