using System;
using System.Collections.Generic;
using System.Text;

using SocialBets.Domain.Core.Interfaces;

namespace SocialBets.Domain.Core.Models
{
    public class BattleHistoryItem : IEntity<int>, IBattle
    {
        public int Id { get; set; }
        public Guid BattleId { get; set; }
        public DateTime TimeOfBattle { get; set; }
        public decimal Bet { get; set; }
        public SocialNetwork SocialNetworkId { get; set; }
        
    }
}
