using BulkyWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options)
        {
            
        }
        public  DbSet<Catergory> Catergories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catergory>().HasData(
                new Catergory { ID = 1, Name = "Ahmed", Display_Order = 1 },
                new Catergory { ID= 2, Name = "Hamza", Display_Order = 1}
                );
        }
    }
}
