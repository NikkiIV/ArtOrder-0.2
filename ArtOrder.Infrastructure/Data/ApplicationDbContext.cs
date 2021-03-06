using ArtOrder.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtOrder.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Commission> Commissions { get; set; }
        public DbSet<CommissionOrder> CommissionOrders { get; set; }
        public DbSet<CommissionInfo> CommissionInfos { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Products> Products { get; set; }       
        public DbSet<Categories> Categories { get; set; }
    }
}