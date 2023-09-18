

using AutoMapper;
using BusinessLayer.Repository.EntityRepository;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;

namespace BusinessLayer.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly MurenoClockContext _context;
    private readonly IMapper _mapper;

    public UnitOfWork(MurenoClockContext context, IMapper mapper)
    {
        _context = context;
        About = new AboutRepository(_context, mapper);
        Contact = new ContactRepository(_context, mapper);
        ContactForm = new ContactFormRepository(_context, mapper);
        Nav = new NavRepository(_context, mapper);
        OnlineSell = new OnlineSellRepository(_context, mapper);
        Product = new ProductRepository(_context, mapper);
        ProductCategory = new ProductCategoryRepository(_context, mapper);
        ProductImage = new ProductImageRepository(_context, mapper);
        Slide=new SlideRepository(_context, mapper);
        Social=new SocialRepository(_context, mapper);

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
