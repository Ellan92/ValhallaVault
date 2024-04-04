using Moq;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.Managers;

public class CategoryManagerTest
{
    [Fact]
    public async Task UpdateCategoryDescriptionAsync_UpdatesDescription()
    {
        // Arrange
        int categoryId = 1;
        string newDescription = "New description";

        var dbContextMock = new Mock<ApplicationDbContext>(); // Skapa en Moq för ApplicationDbContext om det behövs
        var mockRepo = new Mock<CategoryRepo>(MockBehavior.Strict, dbContextMock.Object);
        mockRepo.Setup(repo => repo.VirtualUpdateCategoryDescriptionAsync(categoryId, newDescription)).Returns(Task.CompletedTask);

        var categoryManager = new CategoryManager(mockRepo.Object);

        // Act
        await categoryManager.VirtualUpdateCategoryDescriptionAsync(categoryId, newDescription);

        // Assert
        mockRepo.Verify(repo => repo.VirtualUpdateCategoryDescriptionAsync(categoryId, newDescription), Times.Once);
    }

    [Fact]
    public async Task UpdateCategoryNameAsync_UpdatesCategoryName()
    {
        // Arrange
        int categoryId = 1;
        string newCategoryName = "New category name";

        var dbContextMock = new Mock<ApplicationDbContext>(); // Skapa en Moq för ApplicationDbContext om det behövs
        var mockRepo = new Mock<CategoryRepo>(MockBehavior.Strict, dbContextMock.Object);
        mockRepo.Setup(repo => repo.VirtualUpdateCategoryNameAsync(categoryId, newCategoryName)).Returns(Task.CompletedTask);

        var categoryManager = new CategoryManager(mockRepo.Object);

        // Act
        await categoryManager.VirtualUpdateCategoryNameAsync(categoryId, newCategoryName);

        // Assert
        mockRepo.Verify(repo => repo.VirtualUpdateCategoryNameAsync(categoryId, newCategoryName), Times.Once);
    }

    [Fact]
    public async Task UpdateCategoryDescriptionAsync_CategoryNotFound_ThrowsException()
    {
        // Arrange
        int categoryId = 1;
        string newDescription = "New description";

        var dbContextMock = new Mock<ApplicationDbContext>(); // Skapa en Moq för ApplicationDbContext om det behövs
        var mockRepo = new Mock<CategoryRepo>(MockBehavior.Strict, dbContextMock.Object);
        mockRepo.Setup(repo => repo.VirtualUpdateCategoryDescriptionAsync(categoryId, newDescription)).Throws(new Exception("Category not found."));

        var categoryManager = new CategoryManager(mockRepo.Object);

        // Act & Assert
        await Assert.ThrowsAsync<Exception>(() => categoryManager.VirtualUpdateCategoryDescriptionAsync(categoryId, newDescription));
    }

    [Fact]
    public async Task UpdateCategoryNameAsync_CategoryNotFound_ThrowsException()
    {
        // Arrange
        int categoryId = 1;
        string newCategoryName = "New category name";

        var dbContextMock = new Mock<ApplicationDbContext>(); // Skapa en Moq för ApplicationDbContext om det behövs
        var mockRepo = new Mock<CategoryRepo>(MockBehavior.Strict, dbContextMock.Object);
        mockRepo.Setup(repo => repo.VirtualUpdateCategoryNameAsync(categoryId, newCategoryName)).Throws(new Exception("Category not found."));

        var categoryManager = new CategoryManager(mockRepo.Object);

        // Act & Assert
        await Assert.ThrowsAsync<Exception>(() => categoryManager.VirtualUpdateCategoryNameAsync(categoryId, newCategoryName));
    }
}