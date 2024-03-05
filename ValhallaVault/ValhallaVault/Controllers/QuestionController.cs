using Microsoft.AspNetCore.Mvc;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

namespace ValhallaVault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepo<QuestionModel> _repo;
        private readonly QuestionRepo _questionRepo;
        public QuestionController(ApplicationDbContext dbContext, GenericRepo<QuestionModel> genericRepo, QuestionRepo questionRepo)
        {
            _context = dbContext;
            _repo = genericRepo;
            _questionRepo = questionRepo;
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
        public async Task<IActionResult> PostQuestion(QuestionModel newQuestion)
        {
            if (newQuestion != null)
            {
                await _repo.AddAsync(newQuestion);
                return Ok();
            }
            return BadRequest();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteQuestion = _context.Responses.FirstOrDefault(x => x.Id == id);

            if (deleteQuestion != null)
            {
                await _repo.DeleteAsync(id);
                return Ok();
            }
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateQuestion(int questionId, string newQuestionText)
        {
            if (newQuestionText != null)
            {

                await _questionRepo.UpdateQuestionAsync(questionId, newQuestionText);
                return Ok();
            }
            return BadRequest();
        }
    }
}
