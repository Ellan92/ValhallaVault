using System.ComponentModel.DataAnnotations;

namespace ValhallaVault.Models
{
    public class SubcategoryModel
    {
        [Key]
        public int Id { get; set; }
        public string? SubCategoryName { get; set; }
        public string? Description { get; set; }
        public int SegmentId { get; set; }  // one-to-many med SegmentModel
        public SegmentModel Segment { get; set; }  // one-to-many med SegmentModel
        public List<QuestionModel> Questions { get; set; } = null!; // one-to-many med Questionsmodel
    }
}
