

using BusinessLayer.Repository.EntityRepository;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;

namespace BusinessLayer.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly MurenoClockContext _context;
    private IAboutRepository _aboutRepository;
    private IContactRepository _contactRepository;
    private IContactFormRepository _contactFormRepository;
    private INavRepository _navRepository;
    private IOnlineSellRepository _onlineSellRepository;
    private IProductRepository _productRepository;
    private IProductCategoryRepository _productCategoryRepository;
    private IProductImageRepository _productImageRepository;
    private ISlideRepository _slideRepository;
    private ISocialRepository _socialRepository;

    public UnitOfWork(MurenoClockContext context)
    {
        _context = context;

    }

    public IAboutRepository AboutRepository
    {
        get { return _aboutRepository = _aboutRepository ?? new AboutRepository(_context); }
    }

    public IContactRepository ContactRepository
    {
        get { return _contactRepository = _contactRepository ?? new ContactRepository(_context); }
    }

    public IContactFormRepository ContactFormRepository
    {
        get { return _contactFormRepository = _contactFormRepository ?? new ContactFormRepository(_context); }
    }

    public INavRepository NavRepository
    {
        get { return _navRepository = _navRepository ?? new NavRepository(_context); }
    }

    public IOnlineSellRepository OnlineSellRepository
    {
        get { return _onlineSellRepository = _onlineSellRepository ?? new OnlineSellRepository(_context); }
    }

    public IProductCategoryRepository ProductCategoryRepository
    {
        get { return _productCategoryRepository = _productCategoryRepository ?? new ProductCategoryRepository(_context); }
    }

    public IProductRepository ProductRepository
    {
        get { return _productRepository = _productRepository ?? new ProductRepository(_context); }
    }

    public IProductImageRepository ProductImageRepository
    {
        get { return _productImageRepository = _productImageRepository ?? new ProductImageRepository(_context); }
    }

    public ISlideRepository SlideRepository
    {
        get { return _slideRepository = _slideRepository ?? new SlideRepository(_context); }
    }

    public ISocialRepository SocialRepository
    {
        get { return _socialRepository = _socialRepository ?? new SocialRepository(_context); }
    }

    public void Commit()
    {
        _context.SaveChanges();
    }



    public void RoleBack()
    {
        _context.Dispose();
    }

    public void Dispose()
    {
        Dispose();
        GC.SuppressFinalize(this);
    }

    public void CommitAsync()
    {
        _context.SaveChangesAsync();
    }

    public void RoleBackAsync()
    {
        _context.DisposeAsync();
    }
}
