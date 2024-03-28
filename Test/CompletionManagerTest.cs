using ValhallaVault.Managers;
using ValhallaVault.Models;

namespace Test
{
    public class CompletionTests
    {
        private readonly GenericManager<SubcategoryModel> _genericSubcategoryManager;
        private readonly GenericManager<SegmentModel> _genericSegmentManager;
        /*
         En teoribaserad metod, som den som anv�nds med [Theory] i Xunit eller liknande ramar,
        till�ter att man skriver testfall som �r mer generella och kan testa flera scenarier med samma kod.
        Ist�llet f�r att skriva flera separata testmetoder f�r varje enskilt scenario kan man skriva en
        enda teoribaserad metod som sedan k�rs med olika upps�ttningar av indata.
         */

        [Theory]
        [InlineData(0, 0)] // Om det inte finns n�gra fr�gor ska det kr�vas 0 r�tt f�r att passera
        [InlineData(1, 1)] // Om det finns en fr�ga ska det kr�vas 1 r�tt f�r att passera (0.85 avrundat till n�rmaste heltal)
        [InlineData(2, 2)] // Om det finns tv� fr�gor ska det kr�vas 2 r�tt f�r att passera (1.7 avrundat till n�rmaste heltal)
        [InlineData(3, 3)] // Om det finns tre fr�gor ska det kr�vas 3 r�tt f�r att passera (2.55 avrundat till n�rmaste heltal)
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
            // N�r till exempel antalet fr�gor �r 1 s� kr�vs det 1 r�tt f�r att passera, vilket vi redan definierat i expectedValue, men h�r
            // kollar man s� att result faktiskt blir samma som expectedValue. 

            // Assert
            Assert.Equal(expectedValue, result);
        }


    }


}