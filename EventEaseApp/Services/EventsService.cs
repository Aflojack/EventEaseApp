using EventEaseApp.Models;

namespace EventEaseApp.Services;

public class EventsService
{
    private readonly List<Event> Events = new List<Event>();

    public async Task<List<Event>> GetEvents()
    {
        return Events;
    }
}
