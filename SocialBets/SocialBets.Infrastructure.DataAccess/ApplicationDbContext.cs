using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
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


        //Database Inizializer
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SocialNetwork>().HasData(
                    new SocialNetwork[]
                    {
                        new SocialNetwork
                        {
                            Id = 1,
                            Type = "TikTok"
                        },
                        new SocialNetwork
                        {
                            Id = 2,
                            Type = "Instagram"
                        }
                    }
                );

            builder.Entity<OperationType>().HasData(
                    new OperationType[]
                    {
                        new OperationType
                        {
                            Id = 1,
                            Type = "Debit"
                        },
                        new OperationType
                        {
                            Id = 2,
                            Type = "Credit"
                        }
                    }
                );
        }
    }
}
