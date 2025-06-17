using Microsoft.EntityFrameworkCore;
using MVC_Lecture1.Models;

namespace MVC_Lecture1.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=MVC_11;" +
                    "TrustServerCertificate=True;Trusted_Connection=True;");
            }
        }
    }
}
