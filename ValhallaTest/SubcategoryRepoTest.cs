using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace ValhallaTest
{
    //Farre
    public  class SubcategoryRepoTest
    {

        private readonly SubcategoryRepo _subcategoryRepo;
        private readonly ApplicationDbContext _dbContext;
        private readonly GenericRepo <SubcategoryModel> _genericRepo;

        //this is a constructor
        //sets up the test environment
        public SubcategoryRepoTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ValhallaDB;Trusted_Connection=True;");

            //allows your application to interact with the database.
            _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            //instantiating repos
            _subcategoryRepo = new SubcategoryRepo(_dbContext);
            _genericRepo = new GenericRepo<SubcategoryModel>(_dbContext);
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
        public async Task GetSubcategoryById()
        {
            // Arrange
            int expectedSubcategoryID = 3;

            // Act
            var retrievedSubcategory = await _subcategoryRepo.GetSubcategoryById(expectedSubcategoryID);
            int? retrievedSubcategoryID = retrievedSubcategory?.Id;

            // Assert
            Assert.Equal(expectedSubcategoryID, retrievedSubcategoryID);

        }


        //Tar bort subcategory med ID 5
        // utkommenterad med anledning  av att det inte ska ska konflikter med andra tester.
        //[Fact]
        //public async Task DeleteAsync()
        //{
        //     //arrange
        //     int expectToDelete = 5;

        //     //Act
        //     await _genericRepo.DeleteAsync(expectToDelete);

        //    //assert

        //    Assert.True(expectToDelete == 5, "Successfully deleted :Id");


        //}

        //Uppdatera namnet på en subcategory

        [Fact]
        public async Task UpdateSubcategoryName()
        {
            // Add a test subcategory
            var subcategory = new SubcategoryModel { Id = 1, SubCategoryName = "OldSubcategoryName" };

            
            var subcategoryRepo = new SubcategoryRepo(_dbContext);

            // Act
            await subcategoryRepo.UpdateSubcategoryNameAsync(subcategory.Id, "NewSubcategoryName");

            // Assert
            var updatedSubcategory = await _dbContext.Subcategories.FindAsync(subcategory.Id);
            Assert.Equal("NewSubcategoryName", updatedSubcategory.SubCategoryName); // Verify that the name was updated

        }





    }
}
