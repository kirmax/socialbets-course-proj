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

        public void AttachToBattle()
        {

            
            
            throw new NotImplementedException();
        }

        public void CancelBattle()
        {
            throw new NotImplementedException();
        }

        public async Task CreateBattle(CurrentBattle battle)
        {
            if (battle is null)
                throw new ArgumentNullException();
            
            await _unitOfWork.CurrentBattleRepository.Add(battle);
        }

        public void StartBattle()
        {
            throw new NotImplementedException();
        }

        public void StopBattle()
        {
            throw new NotImplementedException();
        }
    }
}
