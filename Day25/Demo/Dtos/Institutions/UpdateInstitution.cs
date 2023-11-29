
using System.ComponentModel.DataAnnotations;

namespace Demo.Dtos.Institutions
{
    public class UpdateInstitutionRequest
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
    }
}