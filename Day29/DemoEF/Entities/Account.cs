
namespace DemoEF.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string? Type { get; set; }
        public string? AccountNumber { get; set; }
    }
}