
using AutoMapper;
using BusinessLayer.Dtos.Nav;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class NavRepository : GenericRepository<Nav>, INavRepository
{
    public NavRepository(MurenoClockContext context) : base(context)
    {
    }
}
