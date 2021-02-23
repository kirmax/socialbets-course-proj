using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Infrastructure.DataAccess.Repositories
{
    class StatisticsRepository : IRepository<Statistics, int>
    {
        public Task Add(Statistics entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByItem(Statistics entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Statistics>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Statistics> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Statistics entity)
        {
            throw new NotImplementedException();
        }
    }
}
