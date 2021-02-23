using Microsoft.EntityFrameworkCore;
using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Infrastructure.DataAccess.Repositories
{
    class BattlesHistoryRepository : IRepository<BattleHistoryItem, int>
    {
        private readonly ApplicationDbContext _ctx;
        public BattlesHistoryRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Add(BattleHistoryItem entity)
        {
            if (entity is null)
                throw new NullReferenceException();
            await _ctx.BattleHistory.AddAsync(entity);

            await _ctx.SaveChangesAsync();
        }

        public void DeleteByItem(BattleHistoryItem entity)
        {
            if (entity is null)
                throw new NullReferenceException();

            _ctx.BattleHistory.Remove(entity);
        }

        public void DeleteById(int id)
        {
            var entity = _ctx.BattleHistory.Find(id);

            DeleteByItem(entity);
        }

        public async Task<List<BattleHistoryItem>> GetAll()
        {
            return await _ctx.BattleHistory.ToListAsync();
        }

        public async Task<BattleHistoryItem> GetItem(int id)
        {
            return await _ctx.BattleHistory.FindAsync(id);
        }

        public void Update(BattleHistoryItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
