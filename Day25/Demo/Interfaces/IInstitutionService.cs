
using Demo.Models;

namespace Demo.Interfaces
{
    public interface IInstitutionService
    {
        Institution Add(Institution institution);
        Institution Update(string institutionId, Institution institution);
        bool Delete(string institutionId);
        bool IsExist(string institutionId);
        Institution GetInstitution(string institutionId);
        List<Institution> GetInstitutions();
    }
}