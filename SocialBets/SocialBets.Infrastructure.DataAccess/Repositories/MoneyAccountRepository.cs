using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Infrastructure.DataAccess.Repositories
{
    class MoneyAccountRepository : IRepository<MoneyAccount, int>
    {
        public Task Add(MoneyAccount entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByItem(MoneyAccount entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<MoneyAccount>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<MoneyAccount> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(MoneyAccount entity)
        {
            throw new NotImplementedException();
        }
    }
}
