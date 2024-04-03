using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

public class MockCategoryRepo : CategoryRepo
{
    private Dictionary<int, CategoryModel> _categories;


    // Parameterlös konstruktor för Moq
    public MockCategoryRepo() : base(null)
    {
        _categories = new Dictionary<int, CategoryModel>();
    }

    public void AddOrUpdateCategory(CategoryModel category)
    {
        if (_categories.ContainsKey(category.Id))
        {
            _categories[category.Id] = category;
        }
        else
        {
            _categories.Add(category.Id, category);
        }
    }

    public override async Task VirtualUpdateCategoryDescriptionAsync(int categoryId, string newDescription)
    {
        if (_categories.ContainsKey(categoryId))
        {
            _categories[categoryId].Description = newDescription;
            await Task.FromResult(0); // Vänta på en färdig uppgift
        }
        else
        {
            throw new Exception("Category not found.");
        }
    }

    public override async Task VirtualUpdateCategoryNameAsync(int categoryId, string newCategoryName)
    {
        if (_categories.ContainsKey(categoryId))
        {
            _categories[categoryId].CategoryName = newCategoryName;
            await Task.FromResult(0); // Vänta på en färdig uppgift
        }
        else
        {
            throw new Exception("Category not found.");
        }
    }
}