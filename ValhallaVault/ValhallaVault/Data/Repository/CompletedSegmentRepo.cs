using Microsoft.EntityFrameworkCore;
using ValhallaVault.Models;

namespace ValhallaVault.Data.Repository
{
    public class CompletedSegmentRepo
    {

        private readonly ApplicationDbContext _context;

        public CompletedSegmentRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CompletedSegmentModel>> GetCompletedSegmentsByUserIdAsync(string userId)
        {
            return await _context.CompletedSegments
           .Where(c => c.ApplicationUserId == userId)
           .ToListAsync();
        }

        public async Task<CompletedSegmentModel?> GetExistingCompletedSegmentAsync(int categoryId, int segmentId, string userId)
        {
            // Hämta det befintliga CompletedSegmentModel baserat på kategorin, segmentet och användar-ID
            return await _context.CompletedSegments
                .Include(cs => cs.ApplicationUser)
                .Where(cs => cs.CategoryId == categoryId && cs.SegmentId == segmentId && cs.ApplicationUserId == userId)
                .FirstOrDefaultAsync();
        }

        // Gör metoden virtuell
        public virtual async Task<List<CompletedSegmentModel>> VirtualGetCompletedSegmentsByUserIdAsync(string userId)
        {
            return await _context.CompletedSegments
               .Where(c => c.ApplicationUserId == userId)
               .ToListAsync();
        }

        // Gör även denna metoden virtuell
        public virtual async Task<CompletedSegmentModel?> VirtualGetExistingCompletedSegmentAsync(int categoryId, int segmentId, string userId)
        {
            return await _context.CompletedSegments
                .Include(cs => cs.ApplicationUser)
                .Where(cs => cs.CategoryId == categoryId && cs.SegmentId == segmentId && cs.ApplicationUserId == userId)
                .FirstOrDefaultAsync();
        }
    }
}

