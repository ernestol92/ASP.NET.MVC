using Data.Contexts;
using Data.Entities;
using Data.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class StatusRepository : IStatusRepository
    {

        private readonly AppDbContext _context;
        private readonly DbSet<StatusEntity> _dbSet;

        public StatusRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<StatusEntity>();
        }
        public async Task<IEnumerable<StatusEntity>> GetAllStatusesAsync()
        {

            {
                return await _dbSet.AsNoTracking().ToListAsync();
            }
        }
    }
}
