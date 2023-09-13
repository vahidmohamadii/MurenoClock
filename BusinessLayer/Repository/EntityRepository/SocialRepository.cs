
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class SocialRepository : GenericRepository<Social>, ISocialRepository
{
    public SocialRepository(MurenoClockContext context) : base(context)
    {
    }
}
