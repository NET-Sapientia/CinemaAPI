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
    public class CinemasController : ControllerBase
    {
        private readonly IAlgorithmService _algorithmService;

        public CinemasController(IAlgorithmService algorithmService)
        {
            _algorithmService = algorithmService;
        }

        [HttpPost, Route("add-new-cinema")]
        public async Task<ActionResult<Cinema>> PostActor([FromBody] CinemaRequest cinema)
        {

            try
            {
                CinemaResponse result = await _algorithmService.AddNewCinema(cinema);
                return Ok(result);

            }
            catch (AddException ex)
            {
                CinemaResponse errorResponse = new CinemaResponse()
                {
                    Code = 400,
                    Message = APIErrorCodes.ADD_REQUEST_EXCEPTION_MESSAGE + ex.Message
                };
                return BadRequest(errorResponse);
            }


        }

        // GET: api/Algorithms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cinema>>> GetCinemas()
        {
            throw new NotImplementedException();
        }

        // GET: api/Algorithms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CinemaResponse>> GetCinema(int id)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Algorithms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCinema(int id, [FromBody] CinemaRequest cinema)
        {
            throw new NotImplementedException();
        }


        //DELETE: api/Algorithms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCinema(int id)
        {
            throw new NotImplementedException();
        }

        private bool CinemaExists(int id)
        {
            throw new NotImplementedException();
        }


    }
}
