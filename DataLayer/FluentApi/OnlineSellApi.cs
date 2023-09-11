
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi;

public class OnlineSellApi : IEntityTypeConfiguration<OnlineSell>
{
    public void Configure(EntityTypeBuilder<OnlineSell> builder)
    {
        //Id
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).IsRequired();

        //Title
        builder.Property(x => x.Title).HasMaxLength(50);

        //Description
        builder.Property(x => x.Description).HasMaxLength(500);

        //ImageName
        builder.Property(p => p.ImageFileName).IsRequired();
        builder.Property(x => x.ImageFileName).HasMaxLength(500);

        //Link
        builder.Property(p => p.Link).IsRequired();
        builder.Property(x => x.Link).HasMaxLength(100);


    }
}
