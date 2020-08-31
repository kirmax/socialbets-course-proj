using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Infrastructure.DataAccess.Repositories
{
    class SocialNetworksRepository : IRepository<SocialNetwork, int>
    {
        public Task Add(SocialNetwork entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByItem(SocialNetwork entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<SocialNetwork>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SocialNetwork> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(SocialNetwork entity)
        {
            throw new NotImplementedException();
        }
    }
}
