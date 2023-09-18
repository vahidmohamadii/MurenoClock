
using AutoMapper;
using BusinessLayer.Dtos.About;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class AboutRepository : GenericRepository<About, AboutDto>, IAboutRepository
{
    public AboutRepository(MurenoClockContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
