using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Infrastructure.DataAccess.Repositories
{
    class OperationTypesRepository : IRepository<OperationType, int>
    {
        public Task Add(OperationType entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByItem(OperationType entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<OperationType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationType> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(OperationType entity)
        {
            throw new NotImplementedException();
        }
    }
}
