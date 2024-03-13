using System.ComponentModel.DataAnnotations;
using ValhallaVault.Data;

namespace ValhallaVault.Models
{
    public class CompletedSubcategoryModel
    {
        [Key]
        public int Id { get; set; }
        public int SegmentId { get; set; }

        public SubcategoryModel Subcategory { get; set; } = null!;

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; } // Navigering
    }
}
