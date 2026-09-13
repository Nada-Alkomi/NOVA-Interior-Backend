using Microsoft.EntityFrameworkCore;
using NOVA.DAL.Configurations;
using NOVA.DAL.Models;

namespace NOVA.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactInquiry> ContactInquiries { get; set; }

        public DbSet<FurnitureModel> Furnitures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(
                new ContactInquiryConfiguration()
            );

            modelBuilder.ApplyConfiguration(
                new FurnitureConfiguration()
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
