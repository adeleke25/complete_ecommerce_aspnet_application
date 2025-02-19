using Virtual_Ticket.Models;
using Microsoft.EntityFrameworkCore;

namespace Virtual_Ticket.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly eticketDbContext _context;
        public ActorsService(eticketDbContext context)
        {
            _context = context;
        }

        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
