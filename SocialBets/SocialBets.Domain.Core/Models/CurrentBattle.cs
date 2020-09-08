using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using SocialBets.Domain.Core.Interfaces;

namespace SocialBets.Domain.Core.Models
{
    public class CurrentBattle : IEntity<Guid>, IBattle
    {
        public Guid Id { get; set; }
        public ApplicationUser FirstPlayer { get; set; }
        public ApplicationUser SecondPlayer { get; set; } = null;
        public DateTime TimeOfBattle { get; set; }
        public decimal Bet { get; set; }
        public SocialNetwork SocialNetwork { get; set; }
        
    }
}
