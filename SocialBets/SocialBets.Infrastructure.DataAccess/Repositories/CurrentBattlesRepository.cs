using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;

namespace SocialBets.Infrastructure.DataAccess.Repositories
{
    class CurrentBattlesRepository : IRepository<CurrentBattle, Guid>
    {
        public Task Add(CurrentBattle entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByItem(CurrentBattle entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<CurrentBattle>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CurrentBattle> GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(CurrentBattle entity)
        {
            throw new NotImplementedException();
        }
    }
}
