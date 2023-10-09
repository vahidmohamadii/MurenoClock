using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi;

public class AboutApi : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.ToTable("AboutWebsite");

        //AboutId
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        //Title
        builder.Property(x=>x.Title).HasMaxLength(50);

        //Description
        builder.Property(x=>x.Description).HasMaxLength(500);

        //ImageFileName
        builder.Property(x=>x.ImageFileName).HasMaxLength(500);

        //Relation
        builder.HasOne(x => x.language).WithMany(x => x.abouts)
            .HasForeignKey(x => x.LanguageId)
            .OnDelete(DeleteBehavior.Restrict);

        //Seed Data
        builder.HasData(
            new About()
            {

                Id=1,
                Title = "Title",
                Description = "Description",
                ImageFileName = "Title"
               
            });

    }
}
