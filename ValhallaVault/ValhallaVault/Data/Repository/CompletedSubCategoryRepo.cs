using Microsoft.EntityFrameworkCore;
using ValhallaVault.Models;

namespace ValhallaVault.Data.Repository
{
    public class CompletedSubcategoryRepo
    {
        private readonly ApplicationDbContext _context;

        public CompletedSubcategoryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CompletedSubcategoryModel>> GetCompletedSubcategoriesByUserIdAsync(string userId)
        {
            return await _context.CompletedSubcategories
                .Where(c => c.ApplicationUserId == userId)
                .ToListAsync();
        }

        public async Task<CompletedSubcategoryModel?> GetCompletedSubcategoryByParamsAsync(int subcategoryId, int segmentId, string userId)
        {
            return await _context.CompletedSubcategories
                .FirstOrDefaultAsync(cs =>
                    cs.Subcategory.Id == subcategoryId &&
                    cs.SegmentId == segmentId &&
                    cs.ApplicationUserId == userId);
        }

    }

}
