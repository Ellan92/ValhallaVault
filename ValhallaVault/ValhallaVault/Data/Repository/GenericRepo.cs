using Microsoft.EntityFrameworkCore;

namespace ValhallaVault.Data.Repository
{
    public class GenericRepo<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepo(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {

            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await CompleteAsync();
        }

        public async Task DeleteAsync(int id)
        {
            T entityToDelete = await GetByIdAsync(id);

            if (entityToDelete != null)
            {
                _dbSet.Remove(entityToDelete);
                await CompleteAsync();
            }
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
