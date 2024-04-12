using ValhallaVault.Managers;
using ValhallaVault.Models;

namespace ValhallaTest.CalleUnitTest
{
    public class CalleTest
    {

        private readonly GenericManager<SubcategoryModel> _genericSubcategoryManager;
        private readonly GenericManager<SegmentModel> _genericSegmentManager;

        // Metoderna som används i testet
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

        // Test med InlineData för att kolla om användaren har tillräckligt många svar för att komma vidare till nästa subkategori
        [Theory]
        [InlineData(10, 6, false)] // false, eftersom användaren har för få rätt svar.
        [InlineData(20, 16, false)] // false, eftersom användaren har för få rätt svar.
        [InlineData(10, 9, true)] // true, eftersom användaren har tillräckligt många rätt svar.
        [InlineData(20, 17, true)] // true, eftersom användaren har tillräckligt många rätt svar.
        public void UserPassesOrNotSubcategory(int totalQuestions, int correctAnswers, bool expectedResult)
        {

            var subcategory = new SubcategoryModel
            {
                Questions = new List<QuestionModel>(totalQuestions)
            };

            for (int i = 0; i < totalQuestions; i++)
            {
                subcategory.Questions.Add(new QuestionModel());
            }

            CompletionManager completionManager = new(_genericSubcategoryManager, _genericSegmentManager);


            var passed = completionManager.UserPassedSubcategory(subcategory, correctAnswers);

            // Kolla så att man har passerat beroende på hur många frågor som är avklarade
            Assert.Equal(expectedResult, passed);
        }


    }
}
