using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

namespace ValhallaVault.Managers
{
    public class SubcategoryManager
    {
        private readonly SubcategoryRepo _subcategoryRepo;

        public SubcategoryManager(SubcategoryRepo subcategoryRepo)
        {
            _subcategoryRepo = subcategoryRepo;
        }

        public async Task UpdateSubcategoryDescriptionAsync(int subcategoryId, string newDescription)
        {
            await _subcategoryRepo.UpdateSubcategoryDescriptionAsync(subcategoryId, newDescription);
        }

        public async Task<List<SubcategoryModel>> GetSubcategoriesBySegmentIdAsync(int segmentId)
        {
            var subcategories = await _subcategoryRepo.GetSubcategoriesBySegmentIdAsync(segmentId);
            return subcategories;
        }

        public async Task UpdateSubcategoryNameAsync(int subcategoryId, string newName)
        {
            await _subcategoryRepo.UpdateSubcategoryNameAsync(subcategoryId, newName);
        }
    }
}

