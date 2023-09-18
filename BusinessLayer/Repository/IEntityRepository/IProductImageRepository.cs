

using BusinessLayer.Dtos.ProductImage;
using DataLayer.Entities;

namespace BusinessLayer.Repository.IEntityRepository;

public interface IProductImageRepository : IGenericRepository<ProductImage,ProductImageDto>
{
}
