using Microsoft.EntityFrameworkCore;
using ValhallaVault.Models;

namespace ValhallaVault.Data.Repository
{
    public class CategoryRepo
    {
        // protected så att fältet kan nås av klasser som ärver CategoryRepo (MockCategoryRepo) 
        protected readonly ApplicationDbContext _context;

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

        // Virtuella varianter av metoderna för att kunna göra testning. 

        public virtual async Task VirtualUpdateCategoryDescriptionAsync(int categoryId, string newDescription)
        {
            var category = await _context.Categories.FindAsync(categoryId);

            if (category != null)
            {
                category.Description = newDescription;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Category not found.");
            }
        }

        public virtual async Task VirtualUpdateCategoryNameAsync(int categoryId, string newCategoryName)
        {
            var category = await _context.Categories.FindAsync(categoryId);

            if (category != null)
            {
                category.CategoryName = newCategoryName;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Category not found.");
            }
        }
    }
}