using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Virtual_Ticket.Data;
using Virtual_Ticket.Data.Services;

namespace Virtual_Ticket.Controllers
{
 
    public class ActorsController : Controller
    {
        //Inject AppDbContext to send data to and get data from DB
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task <IActionResult> Index()
        {
            
           var data = await _service.GetAll();
            return View(data);
        }
    }
}
