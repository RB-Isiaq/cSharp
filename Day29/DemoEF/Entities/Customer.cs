

namespace DemoEF.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public ICollection<Payment>? Payment { get; set; }
        public ICollection<Account>? Account { get; set; }
    }
}