using System;

namespace EventEaseApp.Services;

public interface IStateService<T> where T: new()
{
    public T LoadState();
    public void ClearState();
}
