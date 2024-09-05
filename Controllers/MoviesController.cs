using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Virtual_Ticket.Data;

namespace Virtual_Ticket.Controllers
{
    public class MoviesController : Controller
    {
        //Inject AppDbContext to send data to and get data from DB
        private readonly eticketDbContext _context;

        public MoviesController(eticketDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n => n.Cinema).OrderBy(n =>n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
