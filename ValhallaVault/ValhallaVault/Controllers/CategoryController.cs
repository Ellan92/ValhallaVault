using Microsoft.AspNetCore.Mvc;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

namespace ValhallaVault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        private readonly GenericRepo<CategoryModel> _repo;
        private readonly CategoryRepo _categoryRepo;
        public CategoryController(ApplicationDbContext dbContext, GenericRepo<CategoryModel> genericRepo, CategoryRepo categoryRepo)
        {
            _context = dbContext;
            _repo = genericRepo;
            _categoryRepo = categoryRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryModel>>> GetAllResponses()
        {
            var responses = await _repo.GetAllAsync();

            return Ok(responses);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var categoryById = await _repo.GetByIdAsync(id);

            if (categoryById != null)
            {
                return Ok(categoryById);
            }
            return BadRequest();
        }


        [HttpPost]
        public async Task<IActionResult> PostCategory(CategoryModel newCategory)
        {
            if (newCategory != null)
            {
                await _repo.AddAsync(newCategory);
                return Ok();
            }
            return BadRequest();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteCategory = _context.Responses.FirstOrDefault(x => x.Id == id);

            if (deleteCategory != null)
            {
                await _repo.DeleteAsync(id);
                return Ok();
            }
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(int categoryId, string newCategoryText)
        {
            if (newCategoryText != null)
            {
                await _categoryRepo.UpdateCategoryDescriptionAsync(categoryId, newCategoryText);
                return Ok();
            }
            return BadRequest();
        }
    }
}
