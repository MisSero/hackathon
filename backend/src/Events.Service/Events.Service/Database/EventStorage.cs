using Events.Service.Entities;
using Microsoft.EntityFrameworkCore;

namespace Events.Service.Database;

public class EventStorage : IEventStorage
{
    private readonly AppDbContext _appDbContext;

    public EventStorage(AppDbContext context)
    {
        _appDbContext = context;
    }

    public async Task<IEnumerable<Event>> GetAllVerifiedEvents()
    {
        return await _appDbContext.Events
            .Where(e => e.IsVerified)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<IEnumerable<Event>> GetAllUnVerifiedEvents()
    {
        return await _appDbContext.Events
            .Where(e => !e.IsVerified)
            .AsNoTracking()
            .ToListAsync();
    }

    public Event? GetEventById(int id)
    {
        return _appDbContext.Events.FirstOrDefault(e => e.Id == id);
    }

    public async Task<int> AddEvent(Event eventModel)
    {
        await _appDbContext.AddAsync(eventModel);

        await _appDbContext.SaveChangesAsync();

        return eventModel.Id;
    }

    public async Task VerifyEvent(int id)
    {
        var eventModel = await _appDbContext.Events
            .FirstOrDefaultAsync(e => e.Id == id);

        if (eventModel == null)
        {
            return;
        }

        eventModel.IsVerified = true;

        await _appDbContext.SaveChangesAsync();
    }
}