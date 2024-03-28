using ValhallaVault.Data;
using ValhallaVault.Managers;
using ValhallaVault.Models;

namespace TestProject
{
    public class FactoryTests
    {
        [Fact]
        public void CreateResultViewModel_ReturnsExpectedViewModel()
        {
            // Arrange
            var factory = new Factory();
            var resultModel = new ResultModel
            {
                Answer = "Test Answer",
                IsCorrect = true,
                QuestionId = 1,
                UserResults = new List<UserResult>()
            };

            // Act
            var resultViewModel = factory.CreateResultViewModel(resultModel);

            // Assert
            Assert.Equal(resultModel.Answer, resultViewModel.Answer);
            Assert.Equal(resultModel.IsCorrect, resultViewModel.IsCorrect);
            Assert.Equal(resultModel.QuestionId, resultViewModel.QuestionId);
            Assert.Same(resultModel.UserResults, resultViewModel.UserResults);
        }

        [Fact]
        public void CreateCorrectResult_ReturnsCorrectResult()
        {
            // Arrange
            var factory = new Factory();
            string answer = "Correct Answer";
            int questionId = 2;

            // Act
            var result = factory.CreateCorrectResult(answer, true, questionId);

            // Assert
            Assert.True(result.IsCorrect);
            Assert.Equal(answer, result.Answer);
            Assert.Equal(questionId, result.QuestionId);
        }

        [Fact]
        public void CreateWrongResult_ReturnsWrongResult()
        {
            // Arrange
            var factory = new Factory();
            string answer = "Wrong Answer";
            int questionId = 3;

            // Act
            var result = factory.CreateWrongResult(answer, false, questionId);

            // Assert
            Assert.False(result.IsCorrect);
            Assert.Equal(answer, result.Answer);
            Assert.Equal(questionId, result.QuestionId);
        }

        [Fact]
        public void CreateUserResult_CreatesExpectedUserResult()
        {
            // Arrange
            var factory = new Factory();
            var user = new ApplicationUser { Id = "User1" };
            var resultModel = new ResultModel { Id = 1 };

            // Act
            var userResult = factory.CreateUserResult(user, resultModel);

            // Assert
            Assert.Same(user, userResult.User);
            Assert.Equal(user.Id, userResult.UserId);
            Assert.Same(resultModel, userResult.Result);
            Assert.Equal(resultModel.Id, userResult.ResultId);
        }

    }
}
