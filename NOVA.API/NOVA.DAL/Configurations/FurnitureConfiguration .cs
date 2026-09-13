using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NOVA.DAL.Models;

namespace NOVA.DAL.Configurations
{
    public class FurnitureConfiguration:IEntityTypeConfiguration<FurnitureModel>
    {
        public void Configure(EntityTypeBuilder<FurnitureModel> modelBuilder)
        {
            modelBuilder.HasKey(f => f.Id);

            modelBuilder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Property(f => f.Category)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Property(f => f.ImageUrl)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
