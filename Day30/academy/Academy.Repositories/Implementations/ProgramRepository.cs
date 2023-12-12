using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Core.Entities;
using Academy.Core.Interfaces;

namespace Academy.Repositories.Implementations
{
    public class ProgramRepository : IProgramRepository
    {
        public Task<Program> Add(Program program)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid programId)
        {
            throw new NotImplementedException();
        }

        public Task<Program> Get(Guid programId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Program>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Program> Update(Program program)
        {
            throw new NotImplementedException();
        }
    }
}