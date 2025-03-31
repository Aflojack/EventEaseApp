namespace EventEaseApp.Services;

public class StateService<T>: IStateService<T> where T: new ()
{
    private T? CurrentState {get; set;}

    public void ClearState()
    {
        CurrentState = default;
    }

    public T LoadState()
    {
        if(ReferenceEquals(CurrentState, null))
        {
            CurrentState = new T();
        }
        return CurrentState;
    }
}
