

using BusinessLayer.Dtos.Contact;
using BusinessLayer.Dtos.ContactForm;
using DataLayer.Entities;

namespace BusinessLayer.Repository.IEntityRepository;

public interface IContactFormRepository : IGenericRepository<ContactForm,ContactFormDto>
{
}
