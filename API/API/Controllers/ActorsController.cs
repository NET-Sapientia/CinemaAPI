using API.Data;
using API.Data.Models;
using API.Data.Requests;
using API.Data.Responses;
using API.Exceptions;
using API.Services;
using API.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorsController : ControllerBase
    {
        private readonly IAlgorithmService _algorithmService;

        public ActorsController(IAlgorithmService algorithmService)
        {
            _algorithmService = algorithmService;
        }

        [HttpPost, Route("add-new-actor")]
        public async Task<ActionResult<Actor>> PostActor([FromBody] ActorRequest actor)
        {

            try
            {
                ActorResponse result = await _algorithmService.AddNewActor(actor);
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
            return Ok(_algorithmService.GetActors());
        }

        // GET: api/Algorithms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActorResponse>> GetActor(int id)
        {
            return Ok(_algorithmService.GetActor(id));
        }

        // PUT: api/Algorithms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActor(int id, [FromBody] ActorRequest actor)
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
