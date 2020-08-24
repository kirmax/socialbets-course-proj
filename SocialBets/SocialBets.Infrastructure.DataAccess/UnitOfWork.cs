using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using SocialBets.Infrastructure.DataAccess.Repositories;
using System;

namespace SocialBets.Infrastructure.DataAccess
{
    public class UnitOfWork : IUnitOfWork               //https://medium.com/@chathuranga94/unit-of-work-for-asp-net-core-706e71abc9d1
    {
        public ApplicationDbContext dbContext { get; set; }
        public IRepository<BattleHistoryItem, int> BattleHistoryRepository { get { return BattleHistoryRepository; } private set 
            {
                if (BattleHistoryRepository is null)
                    BattleHistoryRepository = new BattlesHistoryRepository(dbContext);

            }
        }
        public IRepository<CurrentBattle, int> CurrentBattleRepository { get; private set; }
        public IRepository<MoneyAccount, int> MoneyAccountRepository { get; private set; }
        public IRepository<OperationsHistoryItem, int> OperationsHistoryRepository { get; private set; }
        public IRepository<OperationType, int> OperationTypeRepository { get; private set; }
        public IRepository<SocialNetwork, int> SocialNetworkRepository { get; private set; }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
