namespace ValhallaVault.Models.ViewModels
{
    public class QuestionViewModel
    {
        public int QuestionId { get; set; }
        public bool? IsAnswered { get; set; } // tillägg för viewmodel 
        public string? Question { get; set; }
        public List<string>? Options { get; set; }
        public SolutionModel Solution { get; set; } = null!;
        public int SubcategoryId { get; set; }
        public SubcategoryModel SubCategory { get; set; }

        public bool? IsCorrectAnswer { get; set; } // tillägg för viewmodel 
        public List<ResultModel> Results { get; set; }
    }
}
