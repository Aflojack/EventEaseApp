using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models;

public class Event
{
    [Required]
    public string Name {get; set;}

    [Required]
    public DateTime Date {get; set;} = new DateTime(2025, 1, 1);

    [Required]
    public string Location {get; set;}

    public string Description {get; set;}
}
