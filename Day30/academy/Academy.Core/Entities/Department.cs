

namespace Academy.Core.Entities
{
    public class Department : Entity
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Guid FacultyId { get; set; }
        public Faculty? faculty { get; set; }
        public ICollection<Course>? courses { get; set; }
    }
}