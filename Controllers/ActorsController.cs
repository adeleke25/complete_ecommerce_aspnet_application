using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Virtual_Ticket.Data;

namespace Virtual_Ticket.Controllers
{
 
    public class ActorsController : Controller
    {
        //Inject AppDbContext to send data to and get data from DB
        private readonly eticketDbContext _context;

        public ActorsController(eticketDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
           var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
