using Microsoft.AspNetCore.Mvc;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

namespace ValhallaVault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepo<SubcategoryModel> _repo;
        private readonly SubcategoryRepo _subcategoryRepo;
        public SubcategoryController(ApplicationDbContext dbContext, GenericRepo<SubcategoryModel> genericRepo, SubcategoryRepo subcategoryRepo)
        {
            _context = dbContext;
            _repo = genericRepo;
            _subcategoryRepo = subcategoryRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<SubcategoryModel>>> GetAllSubs()
        {
            var subs = await _repo.GetAllAsync();

            return Ok(subs);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var subcategoryId = await _repo.GetByIdAsync(id);

            if (subcategoryId != null)
            {
                return Ok(subcategoryId);
            }
            return BadRequest();
        }


        [HttpPost]
        public async Task<IActionResult> PostCategory(SubcategoryModel subcategoryModel)
        {
            if (subcategoryModel != null)
            {
                await _repo.AddAsync(subcategoryModel);
                return Ok();
            }
            return BadRequest();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteSubcategory = _context.Subcategories.FirstOrDefault(x => x.Id == id);

            if (deleteSubcategory != null)
            {
                await _repo.DeleteAsync(id);
                return Ok();
            }
            return NoContent();
        }

        //[HttpPut]
        //public async Task<IActionResult> UpdateSubCategory(int segmentId, string newSubcategoryText)
        //{
        //    if (newSubcategoryText != null)
        //    {
        //        await _subcategoryRepo.UpdateSubcategoryDescriptionAsync(segmentId, newSubcategoryText);
        //        return Ok();
        //    }
        //    return BadRequest();
        //}


        //update subcategory name

        [HttpPut]
        public async Task<IActionResult> UpdateSubCategoryName(int subcategoryId, string newSubcategoryText)
        {
            if (newSubcategoryText != null)
            {
                await _subcategoryRepo.UpdateSubcategoryNameAsync(subcategoryId, newSubcategoryText);
                return Ok();
            }
            return BadRequest();
        }




    }
}
