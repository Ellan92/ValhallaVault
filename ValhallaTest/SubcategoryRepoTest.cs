using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;

namespace ValhallaTest
{
    public  class SubcategoryRepoTest
    {

        private readonly SubcategoryRepo _subcategoryRepo;
        private readonly ApplicationDbContext _dbContext;
        public SubcategoryRepoTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ValhallaDB;Trusted_Connection=True;");

            _dbContext = new ApplicationDbContext(optionsBuilder.Options);
            _subcategoryRepo = new SubcategoryRepo(_dbContext);
        }

        //kollar om det hämtar från databasen
        //räknar hur många subcategories det finns etc. 
        [Fact]
        public async Task GetSubcategories()
        {
            //Arrange
            int expectedSubcategories = 45;
            //Act
            var actualSubcategoriesCount = await _subcategoryRepo.GetAllSubcategories();
           //Assert
           Assert.Equal(expectedSubcategories, actualSubcategoriesCount.Count);

        }

        [Fact]
        public async Task GetSubcategoriesBySegmentIdAsync()
        {
            // Arrange
            int expectedSubcategoryID = 3;

            // Act
            var retrievedSubcategory = await _subcategoryRepo.GetSubcategoryById(expectedSubcategoryID);
            int? retrievedSubcategoryID = retrievedSubcategory?.Id;

            // Assert
            Assert.Equal(expectedSubcategoryID, retrievedSubcategoryID);

        }

        //delete


    }
}
