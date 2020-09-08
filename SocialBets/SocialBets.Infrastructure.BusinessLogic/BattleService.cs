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

            if (user is null)
                throw new NullReferenceException();

            if (battle.SecondPlayer is null)
                battle.SecondPlayer = user;

            _unitOfWork.CurrentBattleRepository.Update(battle);

            await _unitOfWork.SaveAsync();
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

        public async Task StartBattle(Guid battleId)
        {
            var battle = await _unitOfWork.CurrentBattleRepository.GetItem(battleId);

            if (battle.SecondPlayer is null)
                return;

            battle.TimeOfStart = DateTime.Now;

            await _unitOfWork.SaveAsync();
        }

        public async Task StopBattle(Guid battleId)
        {
            var battle = await _unitOfWork.CurrentBattleRepository.GetItem(battleId);
            if (battle.TimeOfStart < DateTime.Now)
                return;
            //if (battle.TimeOfStart. + battle.TimeOfBattle < DateTime.Now)
            //    return;
        }
    }
}
