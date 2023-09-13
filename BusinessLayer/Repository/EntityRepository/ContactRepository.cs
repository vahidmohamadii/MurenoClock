

using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class ContactRepository : GenericRepository<Contact>, IContactRepository
{
    public ContactRepository(MurenoClockContext context) : base(context)
    {
    }
}
