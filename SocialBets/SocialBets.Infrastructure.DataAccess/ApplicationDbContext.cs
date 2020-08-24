using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SocialBets.Domain.Core.Models;

namespace SocialBets.Infrastructure.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<OperationsHistoryItem> OperationsHistory { get; set; }
        public DbSet<BattleHistoryItem> BattleHistory { get; set; }
        public DbSet<MoneyAccount> MoneyAccounts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<Statistics> Statistics { get; set; }


    }
}
