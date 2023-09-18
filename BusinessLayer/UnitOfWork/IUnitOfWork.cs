
using BusinessLayer.Repository.IEntityRepository;

namespace BusinessLayer.UnitOfWork;

public interface IUnitOfWork :IDisposable
{
    IAboutRepository About{ get; }
    IContactRepository Contact{ get; }
    IContactFormRepository ContactForm { get; }
    INavRepository Nav { get; }
    IOnlineSellRepository OnlineSell { get; }
    IProductCategoryRepository ProductCategory { get; }
    IProductRepository Product { get; }
    IProductImageRepository ProductImage { get; }
    ISlideRepository Slide { get; }
    ISocialRepository Social { get; }


}
