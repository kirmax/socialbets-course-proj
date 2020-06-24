using System;
using System.Collections.Generic;
using System.Text;

using SocialBets.Domain.Core.Interfaces;

namespace SocialBets.Domain.Core.Models
{
    class CurrentBattle : IEntity<Guid>, IBattle
    {
        public Guid Id { get; set; }
        public DateTime TimeOfBattle { get; set; }
        public decimal Bet { get; set; }
        public SocialNetwork SocialNetworkId { get; set; }
        
    }
}
