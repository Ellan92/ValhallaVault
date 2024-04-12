using ValhallaVault.Managers;
using ValhallaVault.Models;

namespace ValhallaTest.EliasUnitTest
{
	public class EliasTest
	{
		private readonly GenericManager<SubcategoryModel> _genericSubcategoryManager;
		private readonly GenericManager<SegmentModel> _genericSegmentManager;
		public int LimitToPassSubcategory(SubcategoryModel subcategory)
		{
			int numberOfQuestions = subcategory.Questions.Count;
			double limit = numberOfQuestions * 0.85;
			int roundedToNearestInt = (int)Math.Round(limit);
			return roundedToNearestInt;
		}

		[Fact]
		public void LimitToPassSubcategoryReturnsCorrectValueWhenNumberOfQuestionsIsZero()
		{
			var subcategory = new SubcategoryModel { Questions = new List<QuestionModel>() };

			var result = LimitToPassSubcategory(subcategory);

			Assert.Equal(0, result);
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


		[Theory]
		[InlineData(10, 9, true)]
		[InlineData(10, 1, false)]

		public void ToPassOrNotToPass(int totalQuestions, int correctAnswers, bool expectedResult)
		{
			var subcategoryModel = new SubcategoryModel();
			subcategoryModel.Questions = new List<QuestionModel>(totalQuestions);

			CompletionManager manager = new(_genericSubcategoryManager, _genericSegmentManager);

			bool passedOrNot = manager.UserPassedSubcategory(subcategoryModel, correctAnswers);

			Assert.Equal(expectedResult, passedOrNot);
		}
	}
}
