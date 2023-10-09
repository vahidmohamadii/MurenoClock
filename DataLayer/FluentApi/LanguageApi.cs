
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi;

public class LanguageApi : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired();
        builder.Property(x => x.Title).HasMaxLength(200);

        //Relation
        builder.HasOne(x => x.about).WithMany(x => x.languages)
            .HasForeignKey(x => x.AboutId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
