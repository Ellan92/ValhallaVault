using ValhallaVault.Data.Repository;

namespace ValhallaVault.Managers
{
    public class SegmentManager
    {
        private readonly SegmentRepo _segmentRepo;

        public SegmentManager(SegmentRepo segmentRepo)
        {
            _segmentRepo = segmentRepo;
        }
        public async Task UpdateSegmentDescriptionAsync(int segmentId, string newDescription)
        {
            await _segmentRepo.UpdateSegmentDescriptionAsync(segmentId, newDescription);
        }

        public async Task UpdateSegmentNameAsync(int segmentId, string newName)
        {
            await _segmentRepo.UpdateSegmentNameAsync(segmentId, newName);
        }
    }
}
