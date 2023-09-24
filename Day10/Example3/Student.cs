class Student
{
    public Student()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; private set; }
    public string? FirstName { get; set; } = String.Empty;
    public string? LastName { get; set; } = String.Empty;
    public string? Email { get; set; } = String.Empty;
    public string? Phone { get; set; } = String.Empty;

}