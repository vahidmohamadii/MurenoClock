

using AutoMapper;
using BusinessLayer.Dtos.Contact;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class ContactRepository : GenericRepository<Contact,ContactDto>, IContactRepository
{
    public ContactRepository(MurenoClockContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
