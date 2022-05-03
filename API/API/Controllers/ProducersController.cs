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
    public class ProducersController : ControllerBase
    {
        private readonly IAlgorithmService _algorithmService;

        public ProducersController(IAlgorithmService algorithmService)
        {
            _algorithmService = algorithmService;
        }

        [HttpPost, Route("add-new-producer")]
        public async Task<ActionResult<Producer>> PostProducer([FromBody] ProducerRequest producer)
        {

            try
            {
                ProducerResponse result = await _algorithmService.AddNewProducer(producer);
                return Ok(result);

            }
            catch (AddException ex)
            {
                ProducerResponse errorResponse = new ProducerResponse()
                {
                    Code = 400,
                    Message = APIErrorCodes.ADD_REQUEST_EXCEPTION_MESSAGE + ex.Message
                };
                return BadRequest(errorResponse);
            }


        }

        // GET: api/Algorithms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producer>>> GetProducers()
        {
            throw new NotImplementedException();
        }

        // GET: api/Algorithms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProducerResponse>> GetProducer(int id)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Algorithms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducer(int id, [FromBody] ProducerRequest producer)
        {
            throw new NotImplementedException();
        }


        //DELETE: api/Algorithms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducer(int id)
        {
            throw new NotImplementedException();
        }

        private bool ProducerExists(int id)
        {
            throw new NotImplementedException();
        }

    }
}
