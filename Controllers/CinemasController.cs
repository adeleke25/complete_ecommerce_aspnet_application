using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Virtual_Ticket.Data;

namespace Virtual_Ticket.Controllers
{
    public class CinemasController : Controller
    {
        //Inject AppDbContext to send data to and get data from DB
        private readonly eticketDbContext _context;

        public CinemasController(eticketDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
