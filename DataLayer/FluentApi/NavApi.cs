using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi;

public class NavApi : IEntityTypeConfiguration<Nav>
{
    public void Configure(EntityTypeBuilder<Nav> builder)
    {
        //Id
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        //Title
        builder.Property(p => p.Title).IsRequired();
        builder.Property(x => x.Title).HasMaxLength(50);

        //ImageFikeName
        builder.Property(p => p.ImageFileName).IsRequired();
        builder.Property(x => x.Title).HasMaxLength(500);

        //Link
        builder.Property(p => p.Link).IsRequired();
        builder.Property(x => x.Title).HasMaxLength(100);
    }
}
