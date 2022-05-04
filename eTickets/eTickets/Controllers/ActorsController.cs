using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eTickets.Data.Services;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)  //konstruktor
        {
            _service = service;
        }

        public async Task<IActionResult> Index()  //Default-nak adta az Index() nevet
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
