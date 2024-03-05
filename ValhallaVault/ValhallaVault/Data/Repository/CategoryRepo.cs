namespace ValhallaVault.Data.Repository
{
    public class CategoryRepo
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task UpdateCategoryDescriptionAsync(int categoryId, string newDescription)
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
    }
}