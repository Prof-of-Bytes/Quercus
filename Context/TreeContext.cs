using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quercus.Admin;
using Quercus.Identity;


namespace Quercus.Models
{

    public class TreeContext : IdentityDbContext<QuercusUser>
    {
        // public DbSet<Oak> Oaks { get; set; }
        // public DbSet<Supinfo> Supinfo { get; set; }
        // public DbSet<Inventory> Inventory { get; set; }
        //public DbSet<QuercusUser> Users {get; set;} = null!;
        public TreeContext(DbContextOptions<TreeContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}