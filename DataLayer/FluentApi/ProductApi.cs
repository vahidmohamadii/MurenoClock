using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi;

public class ProductApi : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        //Id
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).IsRequired();

        //Title
        builder.Property(p => p.Title).IsRequired();
        builder.Property(x => x.Title).HasMaxLength(50);

        //Price
        builder.Property(p => p.Price).IsRequired();

        //
        builder.Property(x => x.Description).HasMaxLength(500);

        //ImageFileName
        builder.Property(p => p.ImageFileName).IsRequired();
        builder.Property(x => x.ImageFileName).HasMaxLength(100);

        //Relation
        builder.HasOne(x => x.productCategory).WithMany(x => x.products)
            .HasForeignKey(x => x.ProductCategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
