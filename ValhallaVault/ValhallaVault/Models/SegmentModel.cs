using System.ComponentModel.DataAnnotations;

namespace ValhallaVault.Models
{
    public class SegmentModel
    {
        [Key]
        public int Id { get; set; }
        public string SegmentName { get; set; } = null!;
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; } = null!;
        public List<QuestionModel> Questions { get; set; } = new();
    }
}
