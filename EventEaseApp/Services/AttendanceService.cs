using System;
using EventEaseApp.Models;

namespace EventEaseApp.Services;

public class AttendanceService
{
    private readonly List<Attender> Attenders = new List<Attender>();

    public async Task<List<Attender>> GetAttenders()
    {
        await Task.Delay(250); // Just for my fancy loading circle
        return Attenders;
    }

    public async Task<List<Attender>> GetListAttenderByEventId(int id)
    {
        await Task.Delay(250); // Just for my fancy loading circle
        return Attenders.Where(o=>o.EventId==id).ToList();
    }
    
    public async Task<Attender?> GetAttender(int id)
    {
        await Task.Delay(250); // Just for my fancy loading circle
        if(id>=0 && id<Attenders.Count)
        {
            return Attenders[id];
        }
        return null;
    }

    public async Task AddAttender(Attender newAttender)
    {
        await Task.Delay(250); // Just for my fancy loading circle
        Attenders.Add(newAttender);
    }
}
