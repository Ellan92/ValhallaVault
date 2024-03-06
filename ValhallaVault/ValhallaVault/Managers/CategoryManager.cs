using ValhallaVault.Data.Repository;
namespace ValhallaVault.Managers
{
    public class CategoryManager
    {
        private readonly CategoryRepo _categoryRepo;

        public CategoryManager(CategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public async Task UpdateCategoryDescriptionAsync(int categoryId, string newDescription)
        {
            await _categoryRepo.UpdateCategoryDescriptionAsync(categoryId, newDescription);
        }

        public async Task UpdateCategoryNameAsync(int categoryId, string newCategoryName)
        {
            await _categoryRepo.UpdateCategoryNameAsync(categoryId, newCategoryName);
        }
    }
}

