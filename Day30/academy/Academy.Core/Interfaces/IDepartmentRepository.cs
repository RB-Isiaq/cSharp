
using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<Department> Add(Department department);
        Task<Department> Update(Department department);
        Task<Department> Get(Guid departmentId);
        Task<List<Department>> GetAll();
        Task<bool> Delete(Guid departmentId);
    }
}