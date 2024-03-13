using ValhallaVault.Models;

namespace ValhallaVault.Managers
{
    public class CompletionManager
    {

        private readonly GenericManager<SubcategoryModel> _genericSubcategoryManager;
        private readonly GenericManager<SegmentModel> _genericSegmentManager;


        public CompletionManager(GenericManager<SubcategoryModel> genericSubcatergoryManager, GenericManager<SegmentModel> genericSegmentManager)
        {
            _genericSegmentManager = genericSegmentManager;
            _genericSubcategoryManager = genericSubcatergoryManager;
        }

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




    }
}
