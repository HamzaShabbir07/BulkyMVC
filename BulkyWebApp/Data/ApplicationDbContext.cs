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

    }
}
