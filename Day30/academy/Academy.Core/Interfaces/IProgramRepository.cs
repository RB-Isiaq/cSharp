
using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface IProgramRepository
    {
        Task<Program> Add(Program program);
        Task<Program> Update(Program program);
        Task<Program> Get(Guid programId);
        Task<List<Program>> GetAll();
        Task<bool> Delete(Guid programId);
    }
}