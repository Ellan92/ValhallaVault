using Microsoft.EntityFrameworkCore;
using ValhallaVault.Models;

namespace ValhallaVault.Data.Repository
{
    public class CategoryRepo
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CategoryModel> UpdateCategoryAsync(CategoryModel categoryModel)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryModel.Id);

            if (category != null)
            {
                category.CategoryName = categoryModel.CategoryName;
                category.Description = categoryModel.Description;
                await _context.SaveChangesAsync();
                return category;
            }
            else
            {
                throw new Exception("Category not found.");
            }

        }


    }
}