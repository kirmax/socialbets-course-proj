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
        void AttachToBattle();
        void CancelBattle();
        void StartBattle();
        void StopBattle();
    }
}
