using System.Text;

namespace Example5
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public string? Name { set; get; }
        public string? Email { set; get; }

        public override string ToString()
        {
          
        }
    }
}