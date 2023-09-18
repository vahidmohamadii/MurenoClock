
using AutoMapper;
using BusinessLayer.Dtos.OnlineSell;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class OnlineSellRepository : GenericRepository<OnlineSell,OnlineSellDto>, IOnlineSellRepository
{
    public OnlineSellRepository(MurenoClockContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
