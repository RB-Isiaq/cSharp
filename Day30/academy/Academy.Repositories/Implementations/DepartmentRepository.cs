
using Academy.Core.Entities;
using Academy.Core.Interfaces;

namespace Academy.Repositories.Implementations
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public Task<Department> Add(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<Department> Get(Guid departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Department> Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}