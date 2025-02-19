using Virtual_Ticket.Models;

namespace Virtual_Ticket.Data.Services
{
    public interface IActorsService
    {
        // Define Method signatures
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
