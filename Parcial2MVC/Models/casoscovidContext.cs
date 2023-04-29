using Microsoft.EntityFrameworkCore;
namespace Parcial2MVC.Models
{
    public class casoscovidContext : DbContext
    {
        public casoscovidContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<departamento> departamento { get; set; }
        public DbSet<genero> genero { get; set; }
    }
}
