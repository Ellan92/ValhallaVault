using ValhallaVault.Managers;
using ValhallaVault.Models;

namespace TestValhallaVault
{
    public class UnitTest1
    {
        private readonly GenericManager<SubcategoryModel> _genericSubcategoryManager;
        private readonly GenericManager<SegmentModel> _genericSegmentManager;
        public int LimitToPassSubcategory(SubcategoryModel subcategory)
        {
            int numberOfQuestions = subcategory.Questions.Count;
            double limit = numberOfQuestions * 0.85;
            int roundedToNearestInt = (int)Math.Round(limit); // antalet frågor man måste ha rätt på för att passera subkategorin.
            return roundedToNearestInt;
        }

        public bool UserPassedSubcategory(SubcategoryModel subcategory, int numberOfCorrectAnswers)
        {
            int minimumCorrectAnswers = LimitToPassSubcategory(subcategory);
            if (numberOfCorrectAnswers < minimumCorrectAnswers)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        [Fact]
        public void LimitToPassSubcategory_ReturnsCorrectValue()
        {
            // Arrange
            var subcategory = new SubcategoryModel();
            subcategory.Questions = new List<QuestionModel>();

            var expected = (int)Math.Round(subcategory.Questions.Count * 0.85);
            CompletionManager completionManager = new(_genericSubcategoryManager, _genericSegmentManager);

            // Act
            var actual = completionManager.LimitToPassSubcategory(subcategory);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 3, false)]
        [InlineData(6, 4, true)]
        public void UserPassedSubcategory_ReturnsCorrectResult(int totalQuestions, int correctAnswers, bool expected)
        {
            // Arrange
            var subcategory = new SubcategoryModel();
            subcategory.Questions = new List<QuestionModel>();

            CompletionManager completionManager = new(_genericSubcategoryManager, _genericSegmentManager);

            // Act
            var actual = completionManager.UserPassedSubcategory(subcategory, correctAnswers);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}