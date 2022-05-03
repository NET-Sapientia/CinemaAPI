using API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)  //konstruktor
        {
            _context = context;
        }

        //If you want u can get all the Producers -->
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();

            //API-T get, set, hogy ne az adatbazisbol kerje le hanem mashonnan 
            return View(allCinemas);
        }
    }
}
