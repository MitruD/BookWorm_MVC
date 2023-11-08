using BookWormWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWormWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Next Package Manager Console: update database - will create a database


        //PMC: add-migration Add Category table to db
        public DbSet<Category> Categories { get; set; }
    }
}
