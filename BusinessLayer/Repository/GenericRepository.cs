
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly MurenoClockContext _context;
    private readonly DbSet<TEntity> Entities;
    public virtual IQueryable<TEntity> Table => Entities;
    public virtual IQueryable<TEntity> TableNoTracking => Entities.AsNoTracking();
    public GenericRepository(MurenoClockContext context)
    {
        _context = context;
        Entities = _context.Set<TEntity>();
  

    }

    #region AsyncMethod
    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "", int pageid = 1)
    {
        var query = Entities.AsQueryable();
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
        int skip = (pageid - 1) * 6;
        //total = query.Count() / 6;
        return query.Take(6).Skip(skip).ToList();
    }
    public async Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await Entities.FindAsync(id, cancellationToken);
        return entity;
    }
    public async Task DeleteByIdAsync(int id,CancellationToken cancellationToken ,bool saveNow = true)
    {
        var entity = GetById(id);
         Entities.Remove(entity);
        if (saveNow)
           await SaveAsync(cancellationToken);
    }
    public async Task DeleteByEntityAsync(TEntity entity,CancellationToken cancellationToken ,bool saveNow = true)
    {
        Entities.Remove(entity);
        if (saveNow)
           await SaveAsync(cancellationToken);
    }
    public async Task DeleteRange(IEnumerable<TEntity> entity,CancellationToken cancellationToken, bool saveNow = true)
    {
        Entities.RemoveRange(entity);
        if (saveNow)
          await  SaveAsync(cancellationToken);
    }
    public async Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true)
    {
        await _context.AddAsync(entity, cancellationToken);
        if(saveNow)
          await SaveAsync(cancellationToken);
        return entity;
    }
    public async Task InsertRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true)
    {
          await _context.AddRangeAsync(entities, cancellationToken);
          if(saveNow)
             await SaveAsync(cancellationToken);

    }
    public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true)
    {
         _context.Update(entity);
          if (saveNow)
            await SaveAsync(cancellationToken);
          return entity;
    }
    public async Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true)
    {
         _context.UpdateRange(entities);
        if (saveNow)
            await SaveAsync(cancellationToken);

    }

    public async Task SaveAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
    #endregion

    #region SyncMethod
    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "")
    {
        var query = Entities.AsQueryable();
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
        var entity = Entities.Find(id);
        return entity;
    }
    public void DeleteById(int id, bool saveNow = true)
    {
        var entity = GetById(id);
        Entities.Remove(entity);
        if (saveNow)
            Save();
    }
    public void DeleteByEntity(TEntity entity, bool saveNow = true)
    {
        Entities.Remove(entity);
        if (saveNow)
            Save();
    }
    public void DeleteRange(IEnumerable<TEntity> entity, bool saveNow = true)
    {
        Entities.RemoveRange(entity);
        if (saveNow)
            Save();
    }
    public TEntity Insert(TEntity entity, bool saveNow = true)
    {
        Entities.Add(entity);
        if (saveNow)
            Save();
        return entity;
    }
    public void InsertRange(IEnumerable<TEntity> entities, bool saveNow = true)
    {
        Entities.AddRange(entities);
        if (saveNow)
            Save();
    }
    public TEntity Update(TEntity entity, bool saveNow = true)
    {
        Entities.Update(entity);
        if (saveNow)
            Save();
        return entity;
    }
    public void UpdateRange(IEnumerable<TEntity> entities, bool saveNow = true)
    {
        Entities.UpdateRange(entities);
        if (saveNow)
            Save();
    }
    public void Save()
    {
        _context.SaveChanges();
    }


    public int Count()
    {
       return Entities.Count();
    }
    #endregion



}
