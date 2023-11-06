using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Interfaces;

namespace Demo.Services
{
    public class FacultyService : IFacultyService
    {
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }
    }
}