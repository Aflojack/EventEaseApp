using EventEaseApp.Models;

namespace EventEaseApp.Services;

public class EventStateService
{
    private Event CurrentState = new Event();

    public Event LoadState()
    {
        return CurrentState;
    }

    public void ClearState()
    {
        CurrentState = new Event();
    }
}
