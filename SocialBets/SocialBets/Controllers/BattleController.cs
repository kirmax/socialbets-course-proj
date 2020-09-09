using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialBets.Domain.Core.Models;
using SocialBets.Domain.Interfaces.Database;
using SocialBets.Services.Interfaces;

namespace SocialBets.Controllers
{
    [Authorize]
    public class BattleController : Controller
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IBattleService _battleService;
        public BattleController(IBattleService battleService)
        {
            _battleService = battleService;
        }

        // GET: Battle
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CurrentBattle battle)
        {
            await _battleService.CreateBattle(battle);
            
            return RedirectToAction("Index", "HomeController");
        }

        //POST: Attach to battle
        [HttpPost]
        public async Task<IActionResult> Attach(Guid battleId)
        {
            await _battleService.AttachToBattle(battleId, User);

            return RedirectToAction("BattleStart", battleId);
        }

        public IActionResult BattleStart(Guid battleId)
        {
            _battleService.StartBattle(battleId);


            
            return RedirectToAction("Index", "HomeController");
        }


        public IActionResult Details()
        {
            return View();
        }

    }
}