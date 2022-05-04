using API.Data;
using API.Data.Models;
using API.Data.Requests;
using API.Data.Responses;
using API.Exceptions;
using API.Services;
using API.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IAlgorithmService _algorithmService;

        public MoviesController(IAlgorithmService algorithmService)
        {
            _algorithmService = algorithmService;
        }

        [HttpPost, Route("add-new-actor")]
        public async Task<ActionResult<Movie>> PostMovie([FromBody] MovieRequest movie)
        {

            try
            {
                MovieResponse result = await _algorithmService.AddNewMovie(movie);
                return Ok(result);

            }
            catch (AddException ex)
            {
                MovieResponse errorResponse = new MovieResponse()
                {
                    Code = 400,
                    Message = APIErrorCodes.ADD_REQUEST_EXCEPTION_MESSAGE + ex.Message
                };
                return BadRequest(errorResponse);
            }


        }

        // GET: api/Algorithms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return Ok(_algorithmService.GetMovies());
        }

        // GET: api/Algorithms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieResponse>> GetMovie(int id)
        {
            return Ok(_algorithmService.GetMovie(id));
        }

        // PUT: api/Algorithms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, [FromBody] MovieRequest movie)
        {
            throw new NotImplementedException();
        }


        //DELETE: api/Algorithms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        private bool MovieExists(int id)
        {
            throw new NotImplementedException();
        }


    }
}
