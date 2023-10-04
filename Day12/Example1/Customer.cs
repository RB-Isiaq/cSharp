class Customer
{
    public Guid CustomerId { get; private set; }
    public string? Name { get; set; }
    public string? Email { get; set; }

    public Customer()
    {
        CustomerId = new Guid();
    }
}