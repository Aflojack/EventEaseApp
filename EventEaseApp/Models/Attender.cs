using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models;

public class Attender
{
    [Required]
    public int EventId {get; set;}

    [Required(ErrorMessage = "Name required.")]
    public string Name {get; set;}

    [EmailAddress]
    [Required(ErrorMessage = "Email address required.")]
    public string Email {get; set;}

    public Attender(){}
    public Attender(int eventId, string name, string email)
    {
        EventId=eventId;
        Name=name;
        Email=email;
    }
}
