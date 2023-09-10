using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context;

public class MurenoClockContext:DbContext
{
    public MurenoClockContext(DbContextOptions<MurenoClockContext> options):base(options)
    {
            
    }
}
