using System.ComponentModel.DataAnnotations;
using ValhallaVault.Data;

namespace ValhallaVault.Models
{
    public class ResponseModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string? CorrectAnswer { get; set; }
        public string? Explanation { get; set; }
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
