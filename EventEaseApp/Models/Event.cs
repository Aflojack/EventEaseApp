using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace EventEaseApp.Models;

public class Event
{
    [Required(ErrorMessage = "Provide a name for the event")]
    public string Name {get; set;}

    [Required(ErrorMessage = "Provide a date for the event")]
    public DateTime Date {get; set;} = new DateTime(2025, 1, 1);

    [Required(ErrorMessage = "Provide a location for the event")]
    public string Location {get; set;}

    [StringLength(250, ErrorMessage = "The description can be up to 250 characters long")]
    public string Description {get; set;}

    public Event(){}
    public Event(string name, DateTime date, string location, string description)
    {
        Name=name;
        Date=date;
        Location=location;
        Description=description;
    }
}
