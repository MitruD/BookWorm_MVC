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
    }
}
