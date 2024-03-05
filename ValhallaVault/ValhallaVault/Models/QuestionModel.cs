using System.ComponentModel.DataAnnotations;

namespace ValhallaVault.Models
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; } = null!;
        public int SubcategoryId { get; set; }
        public SubcategoryModel SubCategory { get; set; } = null!;
    }
}
