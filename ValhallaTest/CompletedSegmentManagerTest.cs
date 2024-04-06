using Moq;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.Managers;
using ValhallaVault.Models;

namespace ValhallaTest
{
    public class CompletedSegmentManagerTest
    {
        [Fact]
        public async Task GetCompletedSegmentsByUserId_ReturnsSegmentsForUser()
        {
            // Arrange
            string userId = "user-id";
            var mockRepo = new Mock<CompletedSegmentRepo>(MockBehavior.Strict, new Mock<ApplicationDbContext>().Object);
            mockRepo.Setup(repo => repo.VirtualGetCompletedSegmentsByUserIdAsync(userId))
                .ReturnsAsync(new List<CompletedSegmentModel>());

            var segmentManager = new CompletedSegmentManager(mockRepo.Object);

            // Act
            var result = await segmentManager.VirtualGetCompletedSegmentsByUserId(userId);

            // Assert
            Assert.NotNull(result);
            mockRepo.Verify(repo => repo.VirtualGetCompletedSegmentsByUserIdAsync(userId), Times.Once);
        }

        [Fact]
        public async Task GetExistingCompletedSegmentAsync_ReturnsSegmentIfExists()
        {
            // Arrange
            int categoryId = 1, segmentId = 2;
            string userId = "user-id";
            var mockRepo = new Mock<CompletedSegmentRepo>(MockBehavior.Strict, new Mock<ApplicationDbContext>().Object);
            mockRepo.Setup(repo => repo.VirtualGetExistingCompletedSegmentAsync(categoryId, segmentId, userId))
                .ReturnsAsync(new CompletedSegmentModel());

            var segmentManager = new CompletedSegmentManager(mockRepo.Object);

            // Act
            var result = await segmentManager.VirtualGetExistingCompletedSegmentAsync(categoryId, segmentId, userId);

            // Assert
            Assert.NotNull(result);
            mockRepo.Verify(repo => repo.VirtualGetExistingCompletedSegmentAsync(categoryId, segmentId, userId), Times.Once);
        }

    }
}
