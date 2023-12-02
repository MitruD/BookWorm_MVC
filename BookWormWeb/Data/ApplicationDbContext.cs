using BookWormWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWormWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options): This is the constructor for the ApplicationDbContext class.
        //It takes an instance of DbContextOptions<ApplicationDbContext> as a parameter.
        //The : base(options) part calls the constructor of the base class (DbContext) with the provided options.
        //The options typically include information about the database connection, such as the connection string.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //1.Next Package Manager Console(PMC): update database - will create a database


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
