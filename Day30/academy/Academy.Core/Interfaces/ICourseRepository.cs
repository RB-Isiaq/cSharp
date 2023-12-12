
using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> Add(Course course);
        Task<Course> Update(Course course);
        Task<Course> Get(Guid courseId);
        Task<List<Course>> GetAll();
        Task<bool> Delete(Guid courseId);
    }
}