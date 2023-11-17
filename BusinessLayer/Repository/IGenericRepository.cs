using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public interface IGenericRepository<TEntity> where TEntity :class
{

    IQueryable<TEntity> Table { get; }
    IQueryable<TEntity> TableNoTracking { get; }

    void DeleteByEntity(TEntity entity, bool saveNow = true);
    Task DeleteByEntityAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true);
    void DeleteById(int id, bool saveNow = true);
    Task DeleteByIdAsync(int id, CancellationToken cancellationToken, bool saveNow = true);
    void DeleteRange(IEnumerable<TEntity> entity, bool saveNow = true);
    Task DeleteRange(IEnumerable<TEntity> entity, CancellationToken cancellationToken, bool saveNow = true);
    List<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "");
    Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "");

    TEntity GetById(int id);
    Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken);
    TEntity Insert(TEntity entity, bool saveNow = true);
    Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true);
    void InsertRange(IEnumerable<TEntity> entities, bool saveNow = true);
    Task InsertRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true);
    void Save();
    Task SaveAsync(CancellationToken cancellationToken);
    TEntity Update(TEntity entity, bool saveNow = true);
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true);
    void UpdateRange(IEnumerable<TEntity> entities, bool saveNow = true);
    Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true);
    int Count();
}
