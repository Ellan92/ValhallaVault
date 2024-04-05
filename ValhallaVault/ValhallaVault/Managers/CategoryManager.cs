using ValhallaVault.Data.Repository;
using ValhallaVault.Models;
namespace ValhallaVault.Managers
{
    public class CategoryManager
    {
        private readonly CategoryRepo _categoryRepo;

        public CategoryManager(CategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }


        public async Task UpdateCategoryAsync(CategoryModel categoryModel)
        {
            await _categoryRepo.UpdateCategoryAsync(categoryModel);
        }
    }
}

