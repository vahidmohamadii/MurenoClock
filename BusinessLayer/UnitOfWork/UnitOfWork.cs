

using AutoMapper;
using BusinessLayer.Repository.EntityRepository;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;

namespace BusinessLayer.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly MurenoClockContext _context;

    public UnitOfWork(MurenoClockContext context)
    {
        _context = context;
        About = new AboutRepository(_context);
        Contact = new ContactRepository(_context);
        ContactForm = new ContactFormRepository(_context);
        Nav = new NavRepository(_context);
        OnlineSell = new OnlineSellRepository(_context);
        Product = new ProductRepository(_context);
        ProductCategory = new ProductCategoryRepository(_context);
        ProductImage = new ProductImageRepository(_context);
        Slide=new SlideRepository(_context);
        Social=new SocialRepository(_context);

    }

    public IAboutRepository About
    {
        get;private set;
    }

    public IContactRepository Contact
    {
        get;private set;
    }

    public IContactFormRepository ContactForm
    {
        get; private set;
    }

    public INavRepository Nav
    {
        get;private set;
    }

    public IOnlineSellRepository OnlineSell
    {
        get;private set;
    }

    public IProductCategoryRepository ProductCategory
    {
        get;private set;
    }

    public IProductRepository Product
    {
        get;private set;
    }

    public IProductImageRepository ProductImage
    {
        get;private set;
    }

    public ISlideRepository Slide
    {
        get;private set;
    }

    public ISocialRepository Social
    {
        get;private set;
    }


    public void Dispose()
    {
        _context.Dispose();
    }


}
