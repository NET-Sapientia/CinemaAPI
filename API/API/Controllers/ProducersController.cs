using API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)  //konstruktor
        {
            _context = context;
        }

        //If you want u can get all the Producers -->
        public async Task<IActionResult> Index()
        {
            var allProducers =await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
