using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Virtual_Ticket.Data;

namespace Virtual_Ticket.Controllers
{
    public class ProducersController : Controller
    {
        //Inject AppDbContext to send data to and get data from DB
        private readonly eticketDbContext _context;

        public ProducersController(eticketDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
