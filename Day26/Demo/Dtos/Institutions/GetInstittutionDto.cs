
using System.ComponentModel.DataAnnotations;

namespace Demo.Dtos.Institutions
{
    public class GetInstittutionDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
    }
}