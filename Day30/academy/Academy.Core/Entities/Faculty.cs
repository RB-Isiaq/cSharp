
namespace Academy.Core.Entities
{
    public class Faculty : Entity
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Guid InstitutionId { get; set; }
        public Institution? institution { get; set; }
        public ICollection<Department>? departments { get; set; }
    }
}