

using BusinessLayer.Dtos.Contact;
using DataLayer.Entities;

namespace BusinessLayer.Repository.IEntityRepository;

public interface IContactRepository:IGenericRepository<Contact,ContactDto>
{
}
