using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Institution
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
    }
}