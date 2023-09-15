
using BusinessLayer.Repository;

namespace BusinessLayer.UnitOfWork;

public interface IUnitOfWork :IDisposable
{
    void Commit();
    void RoleBack();
    IGenericRepository<T> Repository<T>() where T :class;
}
