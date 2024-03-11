using ValhallaVault.Data;
using ValhallaVault.Models;
using ValhallaVault.Models.ViewModels;

namespace ValhallaVault.Managers
{
    public class Factory
    {
        // Klass som endast ansvarar för att skapa nya objekt 

        public ResultViewModel CreateResultViewModel(ResultModel result)
        {
            ResultViewModel resultViewModel = new ResultViewModel
            {
                Answer = result.Answer,
                IsCorrect = result.IsCorrect,
                Question = result.Question,
                QuestionId = result.QuestionId,
                UserResults = result.UserResults,
            };
            return resultViewModel;
        }


        public ResultModel CreateCorrectResult(string answer, bool isCorrect, QuestionModel question, int questionId)
        {
            ResultModel newResult = new ResultModel
            {
                Answer = answer,        // Vad användaren svarade 
                IsCorrect = true,       // Svaret var rätt 
                Question = question,    // Vilken fråga användaren svarade på
                QuestionId = questionId // Vilken fråga användaren svarade på
            };
            return newResult;
        }

        public ResultModel CreateWrongResult(string answer, bool isCorrect, QuestionModel question, int questionId)
        {
            ResultModel newResult = new ResultModel
            {
                Answer = answer,        // Vad användaren svarade 
                IsCorrect = false,       // Svaret var fel 
                Question = question,    // Vilken fråga användaren svarade på
                QuestionId = questionId // Vilken fråga användaren svarade på
            };
            return newResult;
        }

        public UserResult CreateUserResult(ApplicationUser findtheUser, ResultModel newResult)
        {
            UserResult userresult = new UserResult
            {
                User = findtheUser,
                Result = newResult,
                ResultId = newResult.Id,
                UserId = findtheUser.Id
            };
            return userresult;
        }

        public QuestionViewModel CreateQuestionViewModel(QuestionModel question)

        {
            QuestionViewModel viewmodelQuestion = new QuestionViewModel
            {
                Question = question.Question,
                IsAnswered = false,
                Options = question.Options,
                SubcategoryId = question.SubcategoryId,
                SubCategory = question.SubCategory,
                Results = question.Results,
                Solution = question.Solution
            };
            return viewmodelQuestion;
        }

        public QuestionModel CreateQuestionModel(QuestionViewModel question)

        {
            QuestionModel modelQuestion = new QuestionModel
            {
                Question = question.Question,
                Options = question.Options,
                SubcategoryId = question.SubcategoryId,
                SubCategory = question.SubCategory,
                Results = question.Results,
                Solution = question.Solution
            };
            return modelQuestion;
        }
    }
}


