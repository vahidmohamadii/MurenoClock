
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly MurenoClockContext _context;
    private readonly DbSet<TEntity> _dbSet;
    public GenericRepository(MurenoClockContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
  

    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "")
    {
        var query = _dbSet.AsQueryable();
        if (where != null)
        {
            query = query.Where(where);
        }
        if (orderBy != null)
        {
            query = orderBy(query);
        }
        if (!string.IsNullOrEmpty(includes))
        {
            foreach (var item in includes.Split(','))
            {
                query = query.Include(item);
            }


        }
        return  query.ToList();
    }

    public async Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await _dbSet.FindAsync(id,cancellationToken);
        return entity;
    }

    public async Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await _context.AddAsync(entity, cancellationToken);
        SaveAsync();
        return entity;
    }

    public async Task InsertRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
    {
        _context.AddRange(entities,cancellationToken);
        SaveAsync();
      
    }

    public async Task SaveAsync()
    {
       await _context.SaveChangesAsync();
    }
    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "")
    {
        var query = _dbSet.AsQueryable();
        if (where != null)
        {
            query = query.Where(where);
        }
        if (orderBy != null)
        {
            query = orderBy(query);
        }
        if (!string.IsNullOrEmpty(includes))
        {
            foreach (var item in includes.Split(','))
            {
                query = query.Include(item);
            }


        }
        return query.ToList();
    }

    public TEntity GetById(int id)
    {
        var entity = _dbSet.Find(id);
        return entity;
    }

    public async Task DeleteById(int id)
    {
        var entity =await GetByIdAsync(id,CancellationToken.None);
        _dbSet.Remove(entity);
        Save();
    }


    public TEntity Insert(TEntity entity)
    {
         var result = _context.Add(entity);
        Save();
        return entity;
    }
    public void InsertRange(IEnumerable<TEntity> entities)
    {
        _dbSet.AddRange(entities);
        Save();
    }

    public TEntity Update(TEntity entity)
    {
       _dbSet.Update(entity);
        Save();
        return entity;
    }
    public void UpdateRange(IEnumerable<TEntity> entities)
    {
       _dbSet.UpdateRange(entities);
        Save();
    }
    public void Save()
    {
        _context.SaveChanges();
    }

   
}
