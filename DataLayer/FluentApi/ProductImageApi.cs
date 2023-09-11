
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.FluentApi;

public class ProductImageApi : IEntityTypeConfiguration<ProductImage>
{
    public void Configure(EntityTypeBuilder<ProductImage> builder)
    {
        //Id
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        //Title
        builder.Property(x => x.Title).HasMaxLength(50);

        //ImageFileName
        builder.Property(x => x.ImageFileName).IsRequired();
        builder.Property(x => x.ImageFileName).HasMaxLength(100);

        //Relation
        builder.HasOne(x => x.product).WithMany(p => p.productImages)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
