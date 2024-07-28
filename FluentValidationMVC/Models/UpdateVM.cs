using FluentValidationMVC.Entity;

namespace FluentValidationMVC.Models
{
    public class UpdateVM
    {
        public Guid Id { get; set; }    
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? TicketNumber { get; set; }
        public Gender? Gender { get; set; }
    }
}
