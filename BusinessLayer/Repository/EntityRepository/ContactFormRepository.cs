
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class ContactFormRepository : GenericRepository<ContactForm>, IContactFormRepository
{
    public ContactFormRepository(MurenoClockContext context) : base(context)
    {
    }
}
