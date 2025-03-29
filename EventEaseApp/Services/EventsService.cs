using EventEaseApp.Models;

namespace EventEaseApp.Services;

/// <summary>
/// Very dangerous database emulator!
/// Don't touch it just if you REALLY know what are you doing!
/// </summary>
public class EventsService
{
    private readonly List<Event> Events = new List<Event>()
    {
        new Event("Viltrumite Community Event", new DateTime(2026,1,1),"Earth", "Tired of solo planetary domination? Want to meet like-minded conquerors who appreciate a good mustache? Then join us for the Viltrumite Community Event, where intergalactic warriors come together for a day of fun, fitness, and forced allegiance!"),
    };

    public async Task<List<Event>> GetEvents()
    {
        await Task.Delay(250); // Just for my fancy loading circle
        return Events;
    }
    
    public async Task<Event?> GetEvent(int id)
    {
        await Task.Delay(250); // Just for my fancy loading circle
        if(id>=0 && id<Events.Count)
        {
            return Events[id];
        }
        return null;
    }

    public async Task AddEvent(Event newEvent)
    {
        await Task.Delay(250); // Just for my fancy loading circle
        Events.Add(newEvent);
    }
}
