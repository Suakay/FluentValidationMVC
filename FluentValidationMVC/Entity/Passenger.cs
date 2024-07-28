namespace FluentValidationMVC.Entity
{
    public class Passenger
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string ?LastName { get; set; }
        public int? TicketNumber { get; set; }
        public Gender Gender { get; set; }

    }
    public enum Gender
    {
        Male = 1,
        Female = 2,
    }
}
