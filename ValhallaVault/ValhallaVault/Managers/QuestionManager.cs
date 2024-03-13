using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

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
		public async Task UpdateQuestionAndOptionsAsync(int questionId, string newQuestion, List<string> newOptions)
		{
			await _questionRepo.UpdateQuestionAndOptionsAsync(questionId, newQuestion, newOptions);
		}
		public async Task UpdateOptionsAsync(int questionId, List<string> newQuestions)
		{
			await _questionRepo.UpdateOptionsAsync(questionId, newQuestions);
		}

		public async Task<List<QuestionModel>> GetQuestionsBySubcategoryIdAsync(int subcategoryId)
		{

			return await _questionRepo.GetQuestionsBySubcategoryIdAsync(subcategoryId);
		}

		public async Task<SolutionModel?> GetSolutionByQuestionId(int questionId)
		{
			return await _questionRepo.GetSolutionByQuestionId(questionId);
		}

		public async Task<List<QuestionModel>> GetAllQuestionsInCategoryAsync(int categoryId)
		{
			return await _questionRepo.GetAllQuestionsInCategory(categoryId);
		}

	}
}
