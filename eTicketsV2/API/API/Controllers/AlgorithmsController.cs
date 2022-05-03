#nullable disable
using Microsoft.AspNetCore.Mvc;
using API.Data.Models;
using API.Services;
using API.Data.Requests;
using API.Data.Responses;
using API.Exceptions;
using API.Utils;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly IAlgorithmService _algorithmService;

        public AlgorithmsController(IAlgorithmService algorithmService)
        {
            _algorithmService = algorithmService;
        }

        // POST: api/Algorithms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPost, Route("add-new-algorithm")]
        public async Task<ActionResult<Algorithm>> PostAlgorithm([FromBody] AlgorithmRequest algorithm)
        {
                    
            try
            {
                AlgorithmResponse result = await _algorithmService.AddNewAlgorithm(algorithm);
                return Ok(result);
                
            }
            catch (AddException ex)
            {
                AlgorithmResponse errorResponse = new AlgorithmResponse()
                {
                    Code = 400,
                    Message = APIErrorCodes.ADD_REQUEST_EXCEPTION_MESSAGE + ex.Message
                };
                return BadRequest(errorResponse);
            }

           
        }

        // GET: api/Algorithms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Algorithm>>> GetAlgorithms()
        {
            throw new NotImplementedException();
        }

        // GET: api/Algorithms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlgorithmResponse>> GetAlgorithm(int id)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Algorithms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlgorithm(int id, [FromBody] AlgorithmRequest algorithm)
        {
            throw new NotImplementedException();
        }


        //DELETE: api/Algorithms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlgorithm(int id)
        {
            throw new NotImplementedException();
        }

        private bool AlgorithmExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
