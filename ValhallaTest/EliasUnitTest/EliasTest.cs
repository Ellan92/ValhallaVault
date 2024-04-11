using ValhallaVault.Models;

namespace ValhallaTest.EliasUnitTest
{
	public class EliasTest
	{
		public int LimitToPassSubcategory(SubcategoryModel subcategory)
		{
			int numberOfQuestions = subcategory.Questions.Count;
			double limit = numberOfQuestions * 0.85;
			int roundedToNearestInt = (int)Math.Round(limit); // antalet frågor man måste ha rätt på för att passera subkategorin.
			return roundedToNearestInt;
		}

		[Fact]
		public void LimitToPassSubcategoryReturnsCorrectValueWhenNumberOfQuestionsIsZero()
		{
			// Arrange
			var subcategory = new SubcategoryModel { Questions = new List<QuestionModel>() };

			// Act
			var result = LimitToPassSubcategory(subcategory);

			// Assert
			Assert.Equal(0, result);
		}
	}
}
