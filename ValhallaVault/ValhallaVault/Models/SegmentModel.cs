using System.ComponentModel.DataAnnotations;

namespace ValhallaVault.Models
{
    public class SegmentModel
    {
        [Key]

        public int Id { get; set; }
        public string SegmentName { get; set; } = null!;
        public string? Description { get; set; }
        public int CategoryId { get; set; }  // one-to-many med category
        public CategoryModel Category { get; set; } // one-to-many med category
        public List<SubcategoryModel> Subcategories { get; set; } = null!; // one-to-many

        public SubcategoryModel? GetFirstSubcategory()
        {
            // Kontrollera om det finns några subkategorier
            if (Subcategories != null && Subcategories.Count > 0)
            {
                // Returnera den första subkategorin
                return Subcategories[0];
            }
            else
            {
                return null;
            }
        }
    }
}
