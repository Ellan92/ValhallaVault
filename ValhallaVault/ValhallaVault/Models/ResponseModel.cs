using System.ComponentModel.DataAnnotations;
using ValhallaVault.Data;

namespace ValhallaVault.Models
{
    public class ResponseModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
    }
}
