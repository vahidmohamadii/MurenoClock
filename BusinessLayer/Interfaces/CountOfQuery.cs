
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Interfaces;

public class CountOfQuery<T> : ICountOfQuery<T> where T : class
{
    private readonly DbSet<T> entities;
    private readonly MurenoClockContext _context;
    public CountOfQuery(MurenoClockContext context)
    {
        _context = context;
        entities = _context.Set<T>();
    }
    public int PageId { get; set; }
    public int Count()
    {

        return entities.ToList().Count;
    }
}
