namespace ValhallaVault.Data.Repository
{
    public class SubcategoryRepo
    {
        private readonly ApplicationDbContext _context;

        public SubcategoryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task UpdateSubcategoryDescriptionAsync(int subcategoryId, string newDescription)
        {
            var subcategory = await _context.Subcategories.FindAsync(subcategoryId);

            if (subcategory != null)
            {
                subcategory.Description = newDescription;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Subcategory not found.");
            }
        }

        public async Task UpdateSubcategoryNameAsync(int subcategoryId, string newSubcategoryName)
        {
            var subcategory = await _context.Subcategories.FindAsync(subcategoryId);

            if (subcategory != null)
            {
                subcategory.SubCategoryName = newSubcategoryName;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Subcategory not found.");
            }
        }
    }
}
