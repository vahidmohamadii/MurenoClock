using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public interface IGenericRepository<T> where T : class
{
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includes = "");
    Task<T> GetByIdAsync(int id);
    Task<T> InsertAsync(T entity,CancellationToken cancellationToken);
    Task InsertRangeAsync(IEnumerable<T> entities,CancellationToken cancellationToken);
    void SaveAsync();
    List<T> GetAll(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includes = "");
    T GetById(int id);
    T Insert(T entity);
    void InsertRange(IEnumerable<T> entities);
    T Uodate(T entity);
    void UpdateRange(IEnumerable<T> entities);
    void DeleteById(int id);
    void Save();

}
