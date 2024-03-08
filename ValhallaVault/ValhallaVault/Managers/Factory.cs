using ValhallaVault.Data;
using ValhallaVault.Models;

namespace ValhallaVault.Managers
{
    public class Factory
    {
        // Klass som endast ansvarar för att generera nya objekt 

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
    }
}


