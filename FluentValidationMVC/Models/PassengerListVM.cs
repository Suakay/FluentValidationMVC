using FluentValidationMVC.Entity;

namespace FluentValidationMVC.Models
{
    public class PassengerListVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TicketNumber { get; set; }
        public Gender Gender { get; set; }
    }
}
