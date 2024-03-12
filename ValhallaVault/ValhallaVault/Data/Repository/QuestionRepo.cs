using Microsoft.EntityFrameworkCore;
using ValhallaVault.Models;

namespace ValhallaVault.Data.Repository
{
    public class QuestionRepo
    {
        private readonly ApplicationDbContext _context;
        public QuestionRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<QuestionModel>> GetQuestionsBySubcategoryIdAsync(int segmentId)
        {
            return await _context.Questions
                .Where(q => q.SubcategoryId == segmentId)
                .ToListAsync();
        }



        public async Task<SolutionModel?> GetSolutionByQuestionId(int questionId)
        {
            var solution = await _context.Questions
                 .Where(q => q.Id == questionId)
                 .Select(q => q.Solution)
                 .FirstOrDefaultAsync();

            return solution;
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

        public async Task<List<QuestionModel>> GetAllQuestionsInCategory(int categoryId)
        {
            return await _context.Questions.Include(p => p.SubCategory).ThenInclude(p => p.Segment).Where(p => p.SubCategory.Segment.CategoryId == categoryId).ToListAsync();
        }
    }
}
