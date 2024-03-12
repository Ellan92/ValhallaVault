using System.ComponentModel.DataAnnotations;

namespace ValhallaVault.Models
{
    public class ViewModel
    {
        public int Id { get; set; }
        public bool? IsAnswered { get; set; }
        public string? Question { get; set; }
        public List<string>? Options { get; set; }
        public SolutionModel Solution { get; set; } = null!;
        // one-to-one med Solutionmodel
        public int SubcategoryId { get; set; }  // one-to-many med SubcategoryModel
        public SubcategoryModel SubCategory { get; set; }
        // one-to-many med SubcategoryModel
        public List<ResultModel> Results { get; set; } // one-to-many med Resultmodel
    }
}
