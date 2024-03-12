using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValhallaVault.Data;
using ValhallaVault.Models;

namespace ValhallaVault.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SolutionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SolutionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{questionId}")]
        public async Task<ActionResult<SolutionModel>> GetSolutionByQuestionId(int questionId)
        {
            var solution = await _context.Questions
                .Where(q => q.Id == questionId)
                .Select(q => q.Solution)
                .FirstOrDefaultAsync();

            if (solution == null)
            {
                return NotFound();
            }

            return Ok(solution);
        }
    }
}

