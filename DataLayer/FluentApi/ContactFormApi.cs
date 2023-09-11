using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi
{
    public class ContactFormApi : IEntityTypeConfiguration<ContactForm>
    {
        public void Configure(EntityTypeBuilder<ContactForm> builder)
        {
            //ContactFormId
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Id).IsRequired();

            //Title
            builder.Property(p => p.Title).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(50);


            //Email
            builder.Property(p => p.Email).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(50);


            //Message
            builder.Property(p => p.Message).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(1000);

        }
    }
}
