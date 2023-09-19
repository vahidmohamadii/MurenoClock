using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class AboutRepository : GenericRepository<About>, IAboutRepository
{
    public AboutRepository(MurenoClockContext context) : base(context)
    {
    }
}
