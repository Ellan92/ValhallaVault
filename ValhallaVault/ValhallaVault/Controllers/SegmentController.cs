using Microsoft.AspNetCore.Mvc;
using ValhallaVault.Data;
using ValhallaVault.Data.Repository;
using ValhallaVault.Models;

namespace ValhallaVault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SegmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepo<SegmentModel> _repo;
        private readonly SegmentRepo _segmentRepo;
        public SegmentController(ApplicationDbContext dbContext, GenericRepo<SegmentModel> genericRepo, SegmentRepo segmentRepo)
        {
            _context = dbContext;
            _repo = genericRepo;
            _segmentRepo = segmentRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<SegmentModel>>> GetAllQuestions()
        {
            var questions = await _repo.GetAllAsync();

            return Ok(questions);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var segmentById = await _repo.GetByIdAsync(id);

            if (segmentById != null)
            {
                return Ok(segmentById);
            }
            return BadRequest();
        }


        [HttpPost]
        public async Task<IActionResult> PostSegment(SegmentModel segmentModel)
        {
            if (segmentModel != null)
            {
                await _repo.AddAsync(segmentModel);
                return Ok();
            }
            return BadRequest();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteSegment = _context.Segments.FirstOrDefault(x => x.Id == id);

            if (deleteSegment != null)
            {
                await _repo.DeleteAsync(id);
                return Ok();
            }
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSegment(int segmentId, string newSegmentText)
        {
            if (newSegmentText != null)
            {
                await _segmentRepo.UpdateSegmentDescriptionAsync(segmentId, newSegmentText);
                return Ok();
            }
            return BadRequest();
        }
    }
}
