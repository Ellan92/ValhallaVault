using ValhallaVault.Data;

namespace ValhallaVault.Models
{
    public class QuestionUserModel
    {
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; } = null!;

    }
}
