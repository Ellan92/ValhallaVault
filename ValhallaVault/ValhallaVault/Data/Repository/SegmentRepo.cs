using Microsoft.EntityFrameworkCore;
using ValhallaVault.Models;

namespace ValhallaVault.Data.Repository
{
    public class SegmentRepo
    {
        private readonly ApplicationDbContext _context;

        public SegmentRepo(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<SegmentModel>> GetSegmentsByCategoryIdAsync(int categoryId)
        {
            var segments = await _context.Segments
                .Where(s => s.CategoryId == categoryId)
                .ToListAsync();

            return segments;
        }


        public async Task UpdateSegmentDescriptionAsync(int segmentId, string newDescription)
        {
            var segment = await _context.Segments.FindAsync(segmentId);

            if (segment != null)
            {
                segment.Description = newDescription;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Segment not found.");
            }
        }

        public async Task UpdateSegmentNameAsync(int segmentId, string newSegmentName)
        {
            var segment = await _context.Segments.FindAsync(segmentId);

            if (segment != null)
            {
                segment.SegmentName = newSegmentName;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Segment not found.");
            }
        }


    }
}
