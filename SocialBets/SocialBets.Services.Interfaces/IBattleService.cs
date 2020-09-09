using SocialBets.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Services.Interfaces
{
    public interface IBattleService
    {
        Task<List<CurrentBattle>> GetBattles();
        Task CreateBattle(CurrentBattle battle);
        Task AttachToBattle(Guid battleId, ClaimsPrincipal claimsUser);
        void CancelBattle(Guid battleId);
        Task StartBattle(Guid battleId);
        Task StopBattle(Guid battleId);
    }
}
