using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

namespace ValhallaVault.Managers
{
    public class CompletedSubcategoryManager
    {
        private readonly CompletedSubcategoryRepo _completedSubcategoryRepo;

        public CompletedSubcategoryManager(CompletedSubcategoryRepo completedSubcategoryRepo)
        {
            _completedSubcategoryRepo = completedSubcategoryRepo;
        }

        public async Task<List<CompletedSubcategoryModel>> GetCompletedSubcategoriesByUserId(string userId)
        {
            var subcategories = await _completedSubcategoryRepo.GetCompletedSubcategoriesByUserIdAsync(userId);
            return subcategories;
        }
        public async Task<CompletedSubcategoryModel?> GetCompletedSubcategoryByParamsAsync(int subcategoryId, int segmentId, string userId)
        {
            return await _completedSubcategoryRepo.GetCompletedSubcategoryByParamsAsync(subcategoryId, segmentId, userId);
        }


    }
}