namespace ValhallaVault.Data.Repository
{
    public class SegmentRepo
    {
        private readonly ApplicationDbContext _context;

        public SegmentRepo(ApplicationDbContext context)
        {
            _context = context;
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
    }
}
