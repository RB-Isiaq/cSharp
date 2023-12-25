

namespace Academy.Core.Entities
{
    public class Course : Entity
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Guid DepartmentId { get; set; }
        public Department? department { get; set; }
        public ICollection<Program>? programs { get; set; }
    }
}