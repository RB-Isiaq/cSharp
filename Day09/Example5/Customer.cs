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
            StringBuilder builder = new StringBuilder();
            builder.Append("======================\n");
            builder.Append($"Id : {Id}\n");
            builder.Append($"Name : {Name}\n");
            builder.Append($"Email : {Email}\n\n");

            return builder.ToString();
        }
    }
}