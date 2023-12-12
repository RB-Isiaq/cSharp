
namespace DemoEF.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid AccountId { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
    }
}