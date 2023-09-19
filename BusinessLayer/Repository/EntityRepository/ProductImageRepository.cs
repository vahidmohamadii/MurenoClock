using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository
{
    public ProductImageRepository(MurenoClockContext context) : base(context)
    {
    }
}
