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
            try
            {
                await _categoryRepo.UpdateCategoryDescriptionAsync(categoryId, newDescription);
            }
            catch (Exception ex)
            {
                // Anpassa här hur du vill hantera exceptionen när kategorin inte hittas
                throw new Exception("Failed to update category description.", ex);
            }
        }

        public async Task UpdateCategoryNameAsync(int categoryId, string newCategoryName)
        {
            try
            {
                await _categoryRepo.UpdateCategoryNameAsync(categoryId, newCategoryName);
            }
            catch (Exception ex)
            {
                // Anpassa här hur du vill hantera exceptionen när kategorin inte hittas
                throw new Exception("Failed to update category name.", ex);
            }
        }

        public virtual async Task VirtualUpdateCategoryDescriptionAsync(int categoryId, string newDescription)
        {
            try
            {
                await _categoryRepo.VirtualUpdateCategoryDescriptionAsync(categoryId, newDescription);
            }
            catch (Exception ex)
            {
                // Anpassa här hur du vill hantera exceptionen när kategorin inte hittas
                throw new Exception("Failed to update category description.", ex);
            }
        }

        public virtual async Task VirtualUpdateCategoryNameAsync(int categoryId, string newCategoryName)
        {
            try
            {
                await _categoryRepo.VirtualUpdateCategoryNameAsync(categoryId, newCategoryName);
            }
            catch (Exception ex)
            {
                // Anpassa här hur du vill hantera exceptionen när kategorin inte hittas
                throw new Exception("Failed to update category name.", ex);
            }
        }
    }
}