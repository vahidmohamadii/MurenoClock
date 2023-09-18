
using AutoMapper;
using BusinessLayer.Dtos.ProductImage;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class ProductImageRepository : GenericRepository<ProductImage,ProductImageDto>, IProductImageRepository
{
    public ProductImageRepository(MurenoClockContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
