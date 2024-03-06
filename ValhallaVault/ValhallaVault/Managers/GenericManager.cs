using ValhallaVault.Data.Repository;

namespace ValhallaVault.Managers
{
    public class GenericManager<T> where T : class
    {
        private readonly GenericRepo<T> _genericRepo;

        public GenericManager(GenericRepo<T> genericRepo)
        {
            _genericRepo = genericRepo;
        }

        public async Task<List<T>> GetAllAsync()
        {

            return await _genericRepo.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _genericRepo.GetByIdAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _genericRepo.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _genericRepo.DeleteAsync(id);
        }

        public async Task CompleteAsync()
        {
            await _genericRepo.CompleteAsync();
        }
    }
}
