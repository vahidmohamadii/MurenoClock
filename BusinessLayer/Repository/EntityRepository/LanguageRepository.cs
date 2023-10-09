

using BusinessLayer.Repository.IEntityRepository;
using DataLayer.Context;
using DataLayer.Entities;

namespace BusinessLayer.Repository.EntityRepository;

public class LanguageRepository : GenericRepository<Language>, ILanguageRepository
{
    public LanguageRepository(MurenoClockContext context) : base(context)
    {
    }
}
