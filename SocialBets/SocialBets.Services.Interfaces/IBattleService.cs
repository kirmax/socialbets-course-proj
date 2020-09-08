using SocialBets.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Services.Interfaces
{
    public interface IBattleService
    {
        Task CreateBattle(CurrentBattle battle);
        Task AttachToBattle(Guid battleId, ApplicationUser user);
        void CancelBattle(Guid battleId);
        Task StartBattle(Guid battleId);
        Task StopBattle(Guid battleId);
    }
}
