
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi;

public class SlideApi : IEntityTypeConfiguration<Slide>
{
    public void Configure(EntityTypeBuilder<Slide> builder)
    {
        //Id
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        //Title
        builder.Property(x => x.Title).HasMaxLength(50);

        //Description
        builder.Property(x => x.Description).HasMaxLength(500);

        //ImageFileName
        builder.Property(x => x.ImageFileName).IsRequired();
        builder.Property(x => x.ImageFileName).HasMaxLength(100);

        //Link
        builder.Property(x => x.Link).HasMaxLength(100);

    }
}
