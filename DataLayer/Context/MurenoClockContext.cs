using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context;

public class MurenoClockContext:DbContext
{
    public MurenoClockContext(DbContextOptions<MurenoClockContext> options):base(options)
    {
           
    }

    public DbSet<About> abouts { get; set; }
    public DbSet<Contact> contacts { get; set; }
    public DbSet<ContactForm> contactForms { get; set; }
    public DbSet<Nav> Navs { get; set; }
    public DbSet<OnlineSell> OnlineSells { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Slide> Slides { get; set; }
    public DbSet<Social> Socials { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MurenoClockContext).Assembly);
    }


}
