
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly MurenoClockContext _context;
    public GenericRepository(MurenoClockContext context)
    {
            _context=context;
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includes = "")
    {
        var query = _context.Set<T>().AsQueryable();
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

        return await  query.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<T> InsertAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        SaveAsync();
        return entity;
    }




    public void SaveAsync()
    {
        _context.SaveChangesAsync();
    }
    public List<T> GetAll(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includes = "")
    {
        var query=_context.Set<T>().AsQueryable();
        if(where != null)
        {
            query = query.Where(where);
        }
        if(orderBy != null)
        {
            query = orderBy(query);
        }
        if(string.IsNullOrEmpty(includes))
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
        return _context.Set<T>().Find(id);
    }

    public void DeleteById(int id)
    {
        var entity = GetById(id);
       _context.Set<T>().Remove(entity);
        Save();
    }


    public T Insert(T entity)
    {
       _context.Set<T>().Add(entity);
        Save();
        return entity;
    }


    public T Uodate(T entity)
    {
        _context.Set<T>().Update(entity);
        Save();
        return entity;
    }
    public void Save()
    {
        _context.SaveChanges();
    }

 
}
