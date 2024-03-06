namespace ValhallaVault.Data.Repository
{
    public class QuestionRepo
    {
        private readonly ApplicationDbContext _context;
        public QuestionRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task UpdateQuestionAsync(int questionId, string newQuestionText)
        {
            var question = await _context.Questions.FindAsync(questionId);

            if (question != null)
            {
                question.Question = newQuestionText;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Question not found.");
            }
        }
    }
}
