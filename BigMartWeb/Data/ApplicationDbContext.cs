

using BigMartWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BigMartWeb.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }



        public DbSet<Category> Categories { get; set; } //Create table Category


        protected override void OnModelCreating(ModelBuilder modelBuilder) // Seed category table
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SkiFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

        }
    }

}

