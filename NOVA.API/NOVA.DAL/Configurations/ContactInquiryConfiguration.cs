using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NOVA.DAL.Models;

namespace NOVA.DAL.Configurations
{
    public  class ContactInquiryConfiguration:IEntityTypeConfiguration<ContactInquiry>
    {
        public void Configure(EntityTypeBuilder<ContactInquiry> modelbuilder)
        {

            modelbuilder.HasKey(ci => ci.Id);
            modelbuilder.Property(ci => ci.Name).IsRequired().HasMaxLength(100);
            modelbuilder.Property(ci => ci.Email).IsRequired().HasMaxLength(100);
            modelbuilder.Property(ci => ci.Subject).IsRequired().HasMaxLength(200);
            modelbuilder.Property(ci => ci.Message).IsRequired().HasMaxLength(1000);
        }


    }
}
