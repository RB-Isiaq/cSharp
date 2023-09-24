public class Customer
{
    public Customer(string code)
    {
        Code = code;
    }
    public Customer(string code, string name) // constructor overloading
    {
        Code = code;
        Name = name;
    }
    public string? Name;
    public string? Email;
    public string? Phone;
    public string? Address;
    public string? Code;
}