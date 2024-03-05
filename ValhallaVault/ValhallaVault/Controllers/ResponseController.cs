using Microsoft.AspNetCore.Mvc;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ValhallaVault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepo<ResponseModel> _repo;
        public ResponseController(ApplicationDbContext dbContext, GenericRepo<ResponseModel> genericRepo)
        {
            _context = dbContext;
            _repo = genericRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<ResponseModel>>> GetAllResponses()
        {
            var responses = await _repo.GetAllAsync();

            return Ok(responses);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var responseById = await _repo.GetByIdAsync(id);

            if (responseById != null)
            {
                return Ok(responseById);
            }
            return BadRequest();
        }


        [HttpPost]
        public async Task<IActionResult> PostResponse(ResponseModel newResponse)
        {
            if (newResponse != null)
            {
                await _repo.AddAsync(newResponse);
                return Ok();
            }
            return BadRequest();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteResponse = _context.Responses.FirstOrDefault(x => x.Id == id);

            if (deleteResponse != null)
            {
                await _repo.DeleteAsync(id);
                return Ok();
            }
            return NoContent();
        }


        //[HttpPut]
        //public async Task<IActionResult> UpdateResponse(ResponseModel updatedResponse)
        //{
        //    await _repo.
        //}


    }
}
