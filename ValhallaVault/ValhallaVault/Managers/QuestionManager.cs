using ValhallaVault.Data.Repository;

namespace ValhallaVault.Managers
{
    public class QuestionManager
    {
        private readonly QuestionRepo _questionRepo;

        public QuestionManager(QuestionRepo questionRepo)
        {
            _questionRepo = questionRepo;
        }
        public async Task UpdateQuestionAsync(int questionId, string newQuestion)
        {
            await _questionRepo.UpdateQuestionAsync(questionId, newQuestion);
        }

    }
}
