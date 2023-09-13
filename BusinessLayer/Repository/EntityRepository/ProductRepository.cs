
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(MurenoClockContext context) : base(context)
    {
    }
}
