using Microsoft.EntityFrameworkCore;
using ValhallaVault.Data;

namespace ValhallaVault.Models
{
    [PrimaryKey("UserId", new string[] { "QuestionId" })]
    public class UserQuestionModel
    {
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; } = null!;
        public int ResponseId { get; set; }
        public ResponseModel Response { get; set; } = null!;
    }
}
