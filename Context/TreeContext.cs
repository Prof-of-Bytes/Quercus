using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quercus.Admin;
using Quercus.Identity;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Quercus.Models
#pragma warning restore IDE0130 // Namespace does not match folder structure
{

    public class TreeContext : IdentityDbContext<QuercusUser>
    {
        // public DbSet<Oak> Oaks { get; set; }
        // public DbSet<Supinfo> Supinfo { get; set; }
        // public DbSet<Inventory> Inventory { get; set; }
        public DbSet<User> Users {get; set;}
        public TreeContext(DbContextOptions<TreeContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}