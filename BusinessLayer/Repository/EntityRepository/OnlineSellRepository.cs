
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class OnlineSellRepository : GenericRepository<OnlineSell>, IOnlineSellRepository
{
    public OnlineSellRepository(MurenoClockContext context) : base(context)
    {
    }
}
