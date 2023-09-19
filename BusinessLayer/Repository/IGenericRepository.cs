using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public interface IGenericRepository<TEntity> where TEntity :class
{
    Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "");
    Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<TEntity> InsertAsync(TEntity dto,CancellationToken cancellationToken);
    Task InsertRangeAsync(IEnumerable<TEntity> entityDto, CancellationToken cancellationToken);
    Task SaveAsync();
    List<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "");
    TEntity GetById(int id);
    TEntity Insert(TEntity dto);
    void InsertRange(IEnumerable<TEntity> dtoes);
    TEntity Update(TEntity entity);
    void UpdateRange(IEnumerable<TEntity> entities);
    Task DeleteById(int id);
    void Save();

}
