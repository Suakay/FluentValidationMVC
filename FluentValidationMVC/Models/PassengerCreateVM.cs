using FluentValidationMVC.Entity;

namespace FluentValidationMVC.Models
{
    public class PassengerCreateVM
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TicketNumber { get; set; }
        public Gender ?Gender { get; set; }
    }
}
