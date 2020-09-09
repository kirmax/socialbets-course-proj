using SocialBets.Domain.Interfaces.Database;
using SocialBets.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SocialBets.Domain.Core.Models;
using System.Security.Claims;

namespace SocialBets.Infrastructure.BusinessLogic
{
    public class BattleService : IBattleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public bool isStarted { get; set; } = false;


        public BattleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<CurrentBattle>> GetBattles()
        {
            var battles = await _unitOfWork.CurrentBattleRepository.GetAll();

            return battles;
        }

        public async Task AttachToBattle(Guid battleId, ClaimsPrincipal claimsUser)
        {
            var battle = await _unitOfWork.CurrentBattleRepository.GetItem(battleId);

            var user = await _unitOfWork.UserManager.GetUserAsync(claimsUser);

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

            isStarted = true;
        }

        public async Task StopBattle(Guid battleId)
        {
            var battle = await _unitOfWork.CurrentBattleRepository.GetItem(battleId);

            if (battle.TimeOfStart < DateTime.Now)
                return;
            if (battle.TimeOfEnd < DateTime.Now)
                return;

            isStarted = false;
        }
    }
}
