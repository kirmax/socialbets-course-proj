using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Infrastructure.DataAccess.Repositories
{
    class UserInfoRepository : IRepository<UserInfo, int>
    {
        public Task Add(UserInfo entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByItem(UserInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserInfo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserInfo> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
