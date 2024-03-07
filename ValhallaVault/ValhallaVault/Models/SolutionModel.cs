using System.ComponentModel.DataAnnotations;

namespace ValhallaVault.Models
{
    public class SolutionModel
    {
        [Key]
        public int Id { get; set; }
        public string CorrectAnswer { get; set; } = null!;
        public string? Explanation { get; set; }
        public int QuestionId { get; set; } // one-to one med QuestionModel
        public QuestionModel Question { get; set; } // one-to one med QuestionModel

    }
}
