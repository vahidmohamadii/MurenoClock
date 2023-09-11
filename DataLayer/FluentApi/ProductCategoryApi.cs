using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi;

public class ProductCategoryApi : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        //Id
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).IsRequired();

        //Title
        builder.Property(p => p.Title).IsRequired();
        builder.Property(x => x.Title).HasMaxLength(50);



    }
}
