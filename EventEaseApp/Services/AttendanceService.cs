using System;
using EventEaseApp.Models;

namespace EventEaseApp.Services;

public class AttendanceService
{
    private readonly List<Attender> Attenders = new List<Attender>()
    {
        new Attender(0, "Thragg", "thragg@viltrumiteempire.com"),
        new Attender(0, "Omni-Man", "iamomniman@earthmail.universe"),
        new Attender(0, "Conquest", "conquest@viltrumiteelite.com"),
        new Attender(0, "Lucan", "lucan@viltrumitewarriors.com"),
        new Attender(0, "Viltrumite Soldier #457", "soldier457@viltrumitearmy.com"),
        new Attender(0, "Allen the Alien", "allen@coalitionofplanets.org"),
        new Attender(0, "Mark Grayson", "markg@earthmail.universe"),
        new Attender(0, "Unlucky Human", "helpme@randomhuman.com"), 
        new Attender(0, "Battle Beast", "battlebeast@warriorlegends.com"),
        new Attender(0, "The Guardians of the Globe", "guardians@globeheroes.net"),
        new Attender(0, "Robot", "robot@techcollective.ai"),
        new Attender(0, "Coalition of Planets Rep", "coalitionrep@galacticalliance.net"),
    };

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
