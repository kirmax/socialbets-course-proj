using Microsoft.AspNetCore.Identity;
using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using SocialBets.Infrastructure.DataAccess.Repositories;
using System;
using System.Threading.Tasks;

namespace SocialBets.Infrastructure.DataAccess
{
    public class UnitOfWork : IUnitOfWork        //https://medium.com/@chathuranga94/unit-of-work-for-asp-net-core-706e71abc9d1
    {
        private readonly ApplicationDbContext _ctx;

        public IRepository<BattleHistoryItem, int> BattleHistoryRepository { get; }
        public IRepository<CurrentBattle, int> CurrentBattleRepository { get; }
        public IRepository<MoneyAccount, int> MoneyAccountRepository { get; }
        public IRepository<OperationsHistoryItem, int> OperationsHistoryRepository { get; }
        public IRepository<OperationType, int> OperationTypeRepository { get; }
        public IRepository<SocialNetwork, int> SocialNetworkRepository { get; }
        public IRepository<Statistics, int> StatisticsRepository { get; }
        public IRepository<UserInfo, int> UserInfoRepository { get; }
        public UserManager<ApplicationUser> UserManager { get; }
        public RoleManager<ApplicationRole> RoleManager { get; }


        public UnitOfWork(ApplicationDbContext ctx, UserManager<ApplicationUser> UserManager, RoleManager<ApplicationRole> RoleManager)
        {
            _ctx = ctx;

            BattleHistoryRepository = new DbRepository<BattleHistoryItem>(_ctx);
            CurrentBattleRepository = new DbRepository<CurrentBattle>(_ctx);
            MoneyAccountRepository = new DbRepository<MoneyAccount>(_ctx);
            OperationsHistoryRepository = new DbRepository<OperationsHistoryItem>(_ctx);
            OperationTypeRepository = new DbRepository<OperationType>(_ctx);
            SocialNetworkRepository = new DbRepository<SocialNetwork>(_ctx);
            StatisticsRepository = new DbRepository<Statistics>(_ctx);
            UserInfoRepository = new DbRepository<UserInfo>(_ctx);
            this.UserManager = UserManager;
            this.RoleManager = RoleManager;

        }

        public async Task SaveAsync()
        {
            await _ctx.SaveChangesAsync();
        }

    }
}
