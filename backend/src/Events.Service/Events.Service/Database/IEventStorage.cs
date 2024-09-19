using Events.Service.Entities;

namespace Events.Service.Database;

public interface IEventStorage
{
    public Task<IEnumerable<Event>> GetAllVerifiedEvents();

    public Task<IEnumerable<Event>> GetAllUnVerifiedEvents();

    public Event? GetEventById(int id);

    public Task<int> AddEvent(Event eventModel);

    public Task VerifyEvent(int id);

    public Task DeleteEvent(int id);
}