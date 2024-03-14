using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

namespace ValhallaVault.Managers
{
    public class SegmentManager
    {
        private readonly SegmentRepo _segmentRepo;

        public SegmentManager(SegmentRepo segmentRepo)
        {
            _segmentRepo = segmentRepo;
        }

        public async Task<SegmentModel?> GetSegmentByCategoryAndSegmentIdAsync(int categoryId, int segmentId)
        {
            return await _segmentRepo.GetSegmentByCategoryAndSegmentIdAsync(categoryId, segmentId);
        }

        public async Task UpdateSegmentDescriptionAsync(int segmentId, string newDescription)
        {
            await _segmentRepo.UpdateSegmentDescriptionAsync(segmentId, newDescription);
        }

        public async Task<List<SegmentModel>> GetSegmentsByCategoryIdAsync(int categoryId)
        {
            var segments = await _segmentRepo.GetSegmentsByCategoryIdAsync(categoryId);
            return segments;
        }
        public async Task UpdateSegmentNameAsync(int segmentId, string newName)
        {
            await _segmentRepo.UpdateSegmentNameAsync(segmentId, newName);
        }
    }
}
