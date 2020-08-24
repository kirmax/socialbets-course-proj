using SocialBets.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialBets.Domain.Core.Interfaces
{
    interface IBattle
    {
        public DateTime TimeOfBattle { get; set; }
        public decimal Bet { get; set; }
        public SocialNetwork SocialNetwork { get; set; }
    }
}
