using EventEaseApp.Models;

namespace EventEaseApp.Services;

/// <summary>
/// Very dangerous database emulator!
/// Don't touch it just if you REALLY know what are you doing!
/// </summary>
public class EventsService
{
    private readonly List<Event> Events = new List<Event>();

    public async Task<List<Event>> GetEvents()
    {
        await Task.Delay(250); // Just for my fancy loading circle
        return Events;
    }

    public async Task AddEvent(Event newEvent)
    {
        await Task.Delay(250); // Just for my fancy loading circle
        Events.Add(newEvent);
    }
}
