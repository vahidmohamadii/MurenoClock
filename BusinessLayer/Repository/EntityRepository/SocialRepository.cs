
using AutoMapper;
using BusinessLayer.Dtos.Social;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class SocialRepository : GenericRepository<Social,SocialDto>, ISocialRepository
{
    public SocialRepository(MurenoClockContext context, IMapper mapper) : base(context,mapper)
    {
    }
}
