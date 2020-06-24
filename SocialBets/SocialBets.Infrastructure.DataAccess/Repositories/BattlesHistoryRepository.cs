using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Infrastructure.DataAccess.Repositories
{
    class BattlesHistoryRepository : IRepository<BattleHistoryItem, int>
    {
        public Task Add(BattleHistoryItem entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByItem(BattleHistoryItem entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<BattleHistoryItem>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BattleHistoryItem> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(BattleHistoryItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
