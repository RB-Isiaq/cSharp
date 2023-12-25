
namespace Academy.Core.Entities
{
    public class Program : Entity
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Guid CourseId { get; set; }
        public Course? course { get; set; }
    }
}