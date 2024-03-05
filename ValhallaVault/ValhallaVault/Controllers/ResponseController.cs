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
            var responses = _repo.GetAll();

            return Ok(responses);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var responseById = _repo.GetById(id);

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
                _repo.Add(newResponse);
                return Ok();
            }
            return BadRequest();

        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
