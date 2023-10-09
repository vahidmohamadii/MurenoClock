

using BusinessLayer.AutoFac;
using DataLayer.Entities;

namespace BusinessLayer.Repository.IEntityRepository;

public interface IAboutRepository:IGenericRepository<About>, IScopedDependency
{
}
