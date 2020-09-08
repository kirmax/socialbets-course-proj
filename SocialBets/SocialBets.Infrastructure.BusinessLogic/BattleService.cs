using SocialBets.Domain.Interfaces.Database;
using SocialBets.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SocialBets.Domain.Core.Models;

namespace SocialBets.Infrastructure.BusinessLogic
{
    class BattleService : IBattleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BattleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AttachToBattle(Guid battleId, ApplicationUser user)
        {
            var battle = await _unitOfWork.CurrentBattleRepository.GetItem(battleId);

            if (battle.SecondPlayer is null)
                battle.SecondPlayer = user;

        }

        public void CancelBattle(Guid battleId)
        {
            throw new NotImplementedException();
        }

        public async Task CreateBattle(CurrentBattle battle)
        {
            if (battle is null)
                throw new ArgumentNullException();
            
            await _unitOfWork.CurrentBattleRepository.Add(battle);

            await _unitOfWork.SaveAsync();
        }

        public void StartBattle(Guid battleId)
        {
            throw new NotImplementedException();
        }

        public void StopBattle(Guid battleId)
        {
            throw new NotImplementedException();
        }
    }
}
