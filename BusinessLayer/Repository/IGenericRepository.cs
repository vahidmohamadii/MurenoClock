using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public interface IGenericRepository<T> where T : class
{
    List<T> GetAll(Expression<Func<T,bool>> where=null,Func<IQueryable<T>,IOrderedQueryable<T>> orderBy =null,string includes="");
    T GetById(int id);
    T Insert(T entity);
    T Uodate(T entity);
    void DeleteById(int id);
    void Save();

}
