using SocialBets.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Domain.Interfaces.Database
{
    public interface IUnitOfWork
    {
        public IRepository<BattleHistoryItem, int> BattleHistoryRepository { get; }
        public IRepository<CurrentBattle, int> CurrentBattleRepository { get; }
        public IRepository<MoneyAccount, int> MoneyAccountRepository { get; }
        public IRepository<OperationsHistoryItem, int> OperationsHistoryRepository { get; }
        public IRepository<OperationType, int> OperationTypeRepository { get; }
        public IRepository<SocialNetwork, int> SocialNetworkRepository { get; }

        Task SaveAsync();
    }
}
