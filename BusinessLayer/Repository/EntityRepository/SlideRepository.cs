using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class SlideRepository : GenericRepository<Slide>, ISlideRepository
{
    public SlideRepository(MurenoClockContext context) : base(context)
    {
    }
}
