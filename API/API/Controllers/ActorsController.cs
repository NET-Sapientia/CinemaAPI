using API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)  //konstruktor
        {
            _context = context;
        }

        public IActionResult Index()  //Default-nak adta az Index() nevet
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
