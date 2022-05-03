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
    public class ActorsController : ControllerBase
    {
        private readonly IAlgorithmService _actorService;

        public ActorsController(IAlgorithmService actorService)
        {
            _actorService = actorService;
        }

        // POST: api/Algorithms
        [HttpPost, Route("add-new-actor")]
        public async Task<ActionResult<Actor>> PostActor([FromBody] ActorRequest algorithm)
        {
                    
            try
            {
                AlgorithmResponse result = await _actorService.AddNewAlgorithm(algorithm);
                return Ok(result);
                
            }
            catch (AddException ex)
            {
                ActorResponse errorResponse = new ActorResponse()
                {
                    Code = 400,
                    Message = APIErrorCodes.ADD_REQUEST_EXCEPTION_MESSAGE + ex.Message
                };
                return BadRequest(errorResponse);
            }

           
        }

        // GET: api/Algorithms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> GetActors()
        {
            throw new NotImplementedException();
        }

        // GET: api/Algorithms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActorResponse>> GetActor(int id)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Algorithms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActor(int id, [FromBody] ActorRequest algorithm)
        {
            throw new NotImplementedException();
        }


        //DELETE: api/Algorithms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActor(int id)
        {
            throw new NotImplementedException();
        }

        private bool ActorExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
