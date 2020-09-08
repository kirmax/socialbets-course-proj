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
        Task AttachToBattle(Guid battleId, int userId);
        void CancelBattle(Guid battleId);
        void StartBattle(Guid battleId);
        void StopBattle(Guid battleId);
    }
}
