using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi;

public class ContactApi : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        //ContactId
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        //Title
        builder.Property(x => x.Title).HasMaxLength(50);

        //Description
        builder.Property(x => x.Description).HasMaxLength(500);

        //Email
        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.Email).HasMaxLength(50);

        //Mobile
        builder.Property(x => x.Mobile).IsRequired();
        builder.Property(x => x.Mobile).HasMaxLength(20);

        //PhoneNumber
        builder.Property(x => x.PhoneNumber).HasMaxLength(20);

        //Address
        builder.Property(x => x.Address).HasMaxLength(500);
    }
}
