using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public interface IGenericRepository<TEntity,TDto> where TEntity : class where TDto:class
{
    Task<List<TDto>> GetAllAsync(Expression<Func<TDto, bool>> where = null, Func<IQueryable<TDto>, IOrderedQueryable<TDto>> orderBy = null, string includes = "");
    Task<TDto> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<TDto> InsertAsync(TDto dto,CancellationToken cancellationToken);
    Task InsertRangeAsync(IEnumerable<TDto> entityDto, CancellationToken cancellationToken);
    void SaveAsync();
    List<TDto> GetAll(Expression<Func<TDto, bool>> where = null, Func<IQueryable<TDto>, IOrderedQueryable<TDto>> orderBy = null, string includes = "");
    TDto GetById(int id);
    TDto Insert(TDto dto);
    void InsertRange(IEnumerable<TDto> dtoes);
    TDto Update(TDto entity);
    void UpdateRange(IEnumerable<TDto> entities);
    void DeleteById(int id);
    void Save();

}
