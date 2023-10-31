using Example1.Entities;

namespace Example1.Data
{
    public interface IInstitutionService
    {
        bool AddInstitution(Institution institution);
        bool UpdateInstitution(Institution institution);
        List<Institution> GetAll();
        Institution GetById(int institutionId);
        bool Delete(int institutionId);
    }
}