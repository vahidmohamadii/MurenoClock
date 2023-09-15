

using BusinessLayer.Repository;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly MurenoClockContext _context;
    private bool _disposed = false;

    public UnitOfWork(MurenoClockContext context)
    {
            _context = context;
    }
    public void Commit()
    {
        _context.SaveChanges();
    }

    protected void Dispose(bool disposing)
    {
        if(!this._disposed)
        {
        if(disposing)
            {
                _context.Dispose();
            }
        }
        this._disposed = true;

    }

    public IGenericRepository<T> Repository<T>() where T : class
    {
        return new GenericRepository<T>(_context);
    }

    public void RoleBack()
    {
        foreach (var item in _context.ChangeTracker.Entries())
        {
            switch (item.State)
            {
                case EntityState.Added:
                    item.State = EntityState.Detached;
                    break;
             
            }
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
