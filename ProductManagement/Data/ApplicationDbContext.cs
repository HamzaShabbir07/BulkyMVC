using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Model;

namespace ProductManagement.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Defining the DbSet
        public DbSet<Catergory> Categories { get; set; }

        // Configuring the model and seeding data in a single OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapping the entity to a specific table name
            modelBuilder.Entity<Catergory>().ToTable("Category");

            // Seeding initial data
            modelBuilder.Entity<Catergory>().HasData(
                new Catergory { ID = 1, Name = "Ali", Display_Order = 1 },
                new Catergory { ID = 2, Name = "Hamza", Display_Order = 2 }
            );
        }
    }
}
