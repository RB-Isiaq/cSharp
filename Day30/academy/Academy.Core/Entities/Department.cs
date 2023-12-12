

namespace Academy.Core.Entities
{
    public class Department : Entity
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Guid FacultyId { get; set; }
    }
}