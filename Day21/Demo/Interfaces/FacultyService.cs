using Demo.Models;

namespace Demo.Interfaces
{
    public interface IFacultyService
    {
        void AddFaculty(Faculty faculty);
        void UpdateFaculty(Faculty faculty);
        List<Faculty> GetFaculties();
        Faculty GetFacultyById(int facultyId);
        void DeleteFaculty(int facultyId);

    }
}