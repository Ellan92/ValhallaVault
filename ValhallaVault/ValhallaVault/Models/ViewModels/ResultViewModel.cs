namespace ValhallaVault.Models.ViewModels
{
    public class ResultViewModel
    {
        public string Answer { get; set; } = null!;
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }  // one-to-many med QuestionModel
        public QuestionModel Question { get; set; } // one-to-many med QuestionModel
        public List<UserResult> UserResults { get; set; } // many-to-many med user
    }
}
