using System.ComponentModel.DataAnnotations;
using ValhallaVault.Data;

namespace ValhallaVault.Models
{
    public class ResponseModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string? Answer { get; set; }
        public string? Explanation { get; set; }
        public int QuestionId { get; set; }
        public QuestionModel QuestionModel { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
