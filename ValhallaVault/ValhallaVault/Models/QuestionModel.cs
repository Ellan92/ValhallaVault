using System.ComponentModel.DataAnnotations;

namespace ValhallaVault.Models
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        public string QuestionTitle { get; set; } = null!;
        public int SegmentId { get; set; }
        public SegmentModel Segment { get; set; } = null!;
        public List<QuestionUserModel> QuestionUser { get; set; } = null!;
    }
}
