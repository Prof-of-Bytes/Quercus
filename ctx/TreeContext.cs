using Microsoft.EntityFrameworkCore;
using PlantOpedia.Models.Domain;

namespace Quercus.Models
{

    public class TreeContext : DbContext
    {
        public DbSet<Oak> Oaks { get; set; }
        public DbSet<Supinfo> Supinfo { get; set; } 
        public DbSet<Inventory> Inventory { get; set; } 
        public TreeContext(DbContextOptions<TreeContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}