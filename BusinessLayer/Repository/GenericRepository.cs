
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly MurenoClockContext _context;
    private readonly DbSet<T> _dbSet;
    public GenericRepository(MurenoClockContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includes = "")
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
        if (string.IsNullOrEmpty(includes))
        {
            foreach (var item in includes.Split(','))
            {
                query = query.Include(item);
            }


        }

        return await query.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<T> InsertAsync(T entity, CancellationToken cancellationToken)
    {
        await _context.AddAsync(entity,cancellationToken);
        SaveAsync();
        return entity;
    }

    public async Task InsertRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
    {
       _context.AddRange(entities,cancellationToken);
        SaveAsync();
      
    }

    public void SaveAsync()
    {
        _context.SaveChangesAsync();
    }
    public List<T> GetAll(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includes = "")
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
        if (string.IsNullOrEmpty(includes))
        {
            foreach (var item in includes.Split(','))
            {
                query = query.Include(item);
            }


        }

        return query.ToList();
    }

    public T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public void DeleteById(int id)
    {
        var entity = GetById(id);
        _context.Remove(entity);
        Save();
    }


    public T Insert(T entity)
    {
        _context.Add(entity);
        Save();
        return entity;
    }
    public void InsertRange(IEnumerable<T> entities)
    {
        _context.AddRange(entities);
        Save();
    }

    public T Uodate(T entity)
    {
       _context.Update(entity);
        Save();
        return entity;
    }
    public void UpdateRange(IEnumerable<T> entities)
    {
       _context.UpdateRange(entities);
        Save();
    }
    public void Save()
    {
        _context.SaveChanges();
    }





}
