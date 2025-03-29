using EventEaseApp.Models;

namespace EventEaseApp.Services;

public class AttenderStateService
{
    private Attender CurrentState {get; set;} = new Attender();

    public Attender LoadState()
    {
        return CurrentState;
    }

    public void ClearState()
    {
        CurrentState = new Attender();
    }
}
