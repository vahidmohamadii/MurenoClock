
using AutoMapper;
using BusinessLayer.Dtos.ContactForm;
using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class ContactFormRepository : GenericRepository<ContactForm,ContactFormDto>, IContactFormRepository
{
    public ContactFormRepository(MurenoClockContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
