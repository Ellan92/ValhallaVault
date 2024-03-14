using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

namespace ValhallaVault.Managers
{
    public class CompletedSegmentManager
    {

        private readonly CompletedSegmentRepo _completedSegmentRepo;

        public CompletedSegmentManager(CompletedSegmentRepo completedSegmentRepo)
        {
            _completedSegmentRepo = completedSegmentRepo;
        }
        public async Task<List<CompletedSegmentModel>> GetCompletedSegmentsByUserId(string userId)
        {
            var segments = await _completedSegmentRepo.GetCompletedSegmentsByUserIdAsync(userId);
            return segments;
        }

        public async Task<CompletedSegmentModel?> GetExistingCompletedSegmentAsync(int categoryId, int segmentId, string userId)
        {

            return await _completedSegmentRepo.GetExistingCompletedSegmentAsync(categoryId, segmentId, userId);
        }



    }
}
