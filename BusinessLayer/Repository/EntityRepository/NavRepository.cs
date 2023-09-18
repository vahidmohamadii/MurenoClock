
using AutoMapper;
using BusinessLayer.Dtos.Nav;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class NavRepository : GenericRepository<Nav,NavDto>, INavRepository
{
    public NavRepository(MurenoClockContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
