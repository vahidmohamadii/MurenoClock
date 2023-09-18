
using AutoMapper;
using BusinessLayer.Dtos.Slide;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class SlideRepository : GenericRepository<Slide,SlideDto>, ISlideRepository
{
    public SlideRepository(MurenoClockContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
