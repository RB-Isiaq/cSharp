

namespace Academy.Core.Entities
{
    public class Course : Entity
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Guid DepartmentId { get; set; }
    }
}