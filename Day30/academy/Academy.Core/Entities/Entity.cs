
namespace Academy.Core.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime DateModified { get; set; }
    }
}