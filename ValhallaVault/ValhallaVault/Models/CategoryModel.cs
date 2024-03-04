using System.ComponentModel.DataAnnotations;

namespace ValhallaVault.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public List<SegmentModel> Segments { get; set; } = new();
    }
}
