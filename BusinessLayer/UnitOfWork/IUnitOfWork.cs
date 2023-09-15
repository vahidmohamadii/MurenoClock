
using BusinessLayer.Repository.IEntityRepository;

namespace BusinessLayer.UnitOfWork;

public interface IUnitOfWork :IDisposable
{
    IAboutRepository AboutRepository { get; }
    IContactRepository ContactRepository { get; }
    IContactFormRepository ContactFormRepository { get; }
    INavRepository NavRepository { get; }
    IOnlineSellRepository OnlineSellRepository { get; }
    IProductCategoryRepository ProductCategoryRepository { get; }
    IProductRepository ProductRepository { get; }
    IProductImageRepository ProductImageRepository { get; }
    ISlideRepository SlideRepository { get; }
    ISocialRepository SocialRepository { get; }

    void Commit();
    void RoleBack();
    void CommitAsync();
    void RoleBackAsync();
}
