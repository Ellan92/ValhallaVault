using ValhallaVault.Managers;
using ValhallaVault.Models;

namespace Test
{
    public class CompletionTests
    {
        private readonly GenericManager<SubcategoryModel> _genericSubcategoryManager;
        private readonly GenericManager<SegmentModel> _genericSegmentManager;
        /*
         En teoribaserad metod, som den som används med [Theory] i Xunit eller liknande ramar,
        tillåter att man skriver testfall som är mer generella och kan testa flera scenarier med samma kod.
        Istället för att skriva flera separata testmetoder för varje enskilt scenario kan man skriva en
        enda teoribaserad metod som sedan körs med olika uppsättningar av indata.
         */

        [Theory]
        [InlineData(0, 0)] // Om det inte finns några frågor ska det krävas 0 rätt för att passera
        [InlineData(1, 1)] // Om det finns en fråga ska det krävas 1 rätt för att passera (0.85 avrundat till närmaste heltal)
        [InlineData(2, 2)] // Om det finns två frågor ska det krävas 2 rätt för att passera (1.7 avrundat till närmaste heltal)
        [InlineData(3, 3)] // Om det finns tre frågor ska det krävas 3 rätt för att passera (2.55 avrundat till närmaste heltal)
        public void LimitToPassSubcategory_Returns_CorrectValue(int numberOfQuestions, int expectedValue)
        {
            // Arrange
            var subcategory = new SubcategoryModel
            {
                Questions = new List<QuestionModel>()
            };

            for (int i = 0; i < numberOfQuestions; i++)
            {
                subcategory.Questions.Add(new QuestionModel());
            }

            CompletionManager completionManager = new(_genericSubcategoryManager, _genericSegmentManager);

            // Act
            int result = completionManager.LimitToPassSubcategory(subcategory);
            // När till exempel antalet frågor är 1 så krävs det 1 rätt för att passera, vilket vi redan definierat i expectedValue, men här
            // kollar man så att result faktiskt blir samma som expectedValue. 

            // Assert
            Assert.Equal(expectedValue, result);
        }


    }


}