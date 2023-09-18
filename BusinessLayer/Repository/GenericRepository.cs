
using AutoMapper;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BusinessLayer.Repository;

public class GenericRepository<TEntity, TDto> : IGenericRepository<TEntity, TDto> where TEntity : class where TDto :class
{
    private readonly MurenoClockContext _context;
    private readonly DbSet<TEntity> _dbSet;
    private readonly IMapper _mapper;
    public GenericRepository(MurenoClockContext context, IMapper mapper)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
        _mapper = mapper;

    }

    public async Task<List<TDto>> GetAllAsync(Expression<Func<TDto, bool>> where = null, Func<IQueryable<TDto>, IOrderedQueryable<TDto>> orderBy = null, string includes = "")
    {
        var query = _dbSet.AsQueryable();
        if (where != null)
        {
            var pridicate = _mapper.Map<Expression<Func<TEntity, bool>>>(where);
            query = query.Where(pridicate);
        }
        if (orderBy != null)
        {
            var order = _mapper.Map<Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>>(orderBy);
            query = order(query);
        }
        if (string.IsNullOrEmpty(includes))
        {
            foreach (var item in includes.Split(','))
            {
                query = query.Include(item);
            }


        }
         var result = _mapper.ProjectTo<TDto>(query).ToList();
        return  result;
    }

    public async Task<TDto> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await _dbSet.FindAsync(id,cancellationToken);
        var result=  _mapper.Map<TDto>(entity);
        return result;
    }

    public async Task<TDto> InsertAsync(TDto entityDto, CancellationToken cancellationToken)
    {
         var entity=  _mapper.Map<TEntity>(entityDto);
        await _context.AddAsync(entity, cancellationToken);
        SaveAsync();
        return entityDto;
    }

    public async Task InsertRangeAsync(IEnumerable<TDto> entityDto, CancellationToken cancellationToken)
    {
        var entities=_mapper.Map<TEntity>(entityDto);
        _context.AddRange(entities,cancellationToken);
        SaveAsync();
      
    }

    public async void SaveAsync()
    {
       await _context.SaveChangesAsync();
    }
    public List<TDto> GetAll(Expression<Func<TDto, bool>> where = null, Func<IQueryable<TDto>, IOrderedQueryable<TDto>> orderBy = null, string includes = "")
    {
        var query = _dbSet.AsQueryable();
        if (where != null)
        {
            var pridicate = _mapper.Map<Expression<Func<TEntity, bool>>>(where);
            query = query.Where(pridicate);
        }
        if (orderBy != null)
        {
            var order = _mapper.Map<Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>>(orderBy);
            query = order(query);
        }
        if (!string.IsNullOrEmpty(includes))
        {
            foreach (var item in includes.Split(','))
            {
                query = query.Include(item);
            }


        }
        var result = _mapper.ProjectTo<TDto>(query).ToList();
        return result;
    }

    public TDto GetById(int id)
    {
        var entity = _dbSet.Find(id);
        var result = _mapper.Map<TDto>(entity);
        return result;
    }

    public void DeleteById(int id)
    {
        var entity = GetById(id);
        _context.Remove(entity);
        Save();
    }


    public TDto Insert(TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
         var result = _context.Add(entity);
        Save();
        return dto;
    }
    public void InsertRange(IEnumerable<TDto> dtoes)
    {
        var entities=_mapper.Map<TEntity>(dtoes);
        _context.AddRange(entities);
        Save();
    }

    public TDto Update(TDto dto)
    {
        var entity= _mapper.Map<TEntity>(dto);
       _context.Update(entity);
        Save();
        return dto;
    }
    public void UpdateRange(IEnumerable<TDto> dtoes)
    {
        var entities = _mapper.Map<TEntity>(dtoes);
       _context.UpdateRange(entities);
        Save();
    }
    public void Save()
    {
        _context.SaveChanges();
    }

   
}
