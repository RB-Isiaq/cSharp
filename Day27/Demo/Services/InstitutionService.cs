using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Interfaces;
using Demo.Models;

namespace Demo.Services
{

    public class InstitutionService : IInstitutionService
    {
        private static List<Institution> institutions = new()
        {
            new Institution()
            {
                Id = Guid.NewGuid(),
                Name = "Unilorin",
                City = "Ilorin"
            },
            new Institution()
            {
                Id = Guid.NewGuid(),
                Name = "Unilag",
                City = "Lagos"
            }
        };
        public Institution Add(Institution institution)
        {
            institutions.Add(institution);
            return institution;
        }
        public Institution Update(string institutionId, Institution updatedInstitution)
        {
            var existingInstitution = institutions.FirstOrDefault(m => m.Id.ToString() == institutionId);

            if (existingInstitution != null)
            {
                var index = institutions.IndexOf(existingInstitution);
                institutions[index] = updatedInstitution;
            }

            return updatedInstitution;
        }
        public bool Delete(string institutionId)
        {
            var toBeDeleted = institutions.Where(m => m.Id.ToString() == institutionId).SingleOrDefault();
            institutions.Remove(toBeDeleted ?? new Institution());
            return true;
        }
        public Institution GetInstitution(string institutionId)
        {
            var existing = institutions.Where(m => m.Id.ToString() == institutionId).SingleOrDefault();
            return existing ?? new Institution();
        }
        public List<Institution> GetInstitutions()
        {
            return institutions;
        }

        public bool IsExist(string institutionId)
        {
            var existing = institutions.Where(m => m.Id.ToString() == institutionId).SingleOrDefault();
            return existing != null;
        }
    }
}