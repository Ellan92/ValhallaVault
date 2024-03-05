using System.ComponentModel.DataAnnotations;

namespace ValhallaVault.Models
{
    public class SubcategoryModel
    {
        [Key]
        public int Id { get; set; }
        public string SubCategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public List<QuestionModel> Questions { get; set; } = new();
        public int SegmentId { get; set; }
        public SegmentModel Segment { get; set; } = null!;
    }
}
