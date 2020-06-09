using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Domain.Interfaces.Database
{
    interface IRepository<TEntity, TIdType> where 
        TEntity : class
    {
        Task Add(TEntity entity);
        Task<TEntity> GetItem(TIdType id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task DeleteByItem(TEntity entity);
        Task DeleteById(TIdType id);
    }
}
