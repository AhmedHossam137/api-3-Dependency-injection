using Microsoft.EntityFrameworkCore;

namespace api_3_Dependency_injection.Models
{
    public class shopContext:DbContext
    {
        public shopContext()
        {
            
        }
        public shopContext(DbContextOptions<shopContext>option):base(option) 
        {
            
        }
        public virtual DbSet<catlog> catlog { get; set; }
        public virtual DbSet<product> product { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=AHMEDHOSSAM;Database=testAPI;Trusted_Connection=True;TrustServerCertificate=True;");
        //}
    }
}
