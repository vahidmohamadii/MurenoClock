
using AutoMapper;
using BusinessLayer.Dtos.Product;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class ProductRepository : GenericRepository<Product,ProductDto>, IProductRepository
{
    public ProductRepository(MurenoClockContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
