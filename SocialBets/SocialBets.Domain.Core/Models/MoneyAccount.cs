using System;
using System.Collections.Generic;
using System.Text;

using SocialBets.Domain.Core.Interfaces;

namespace SocialBets.Domain.Core.Models
{
    public class MoneyAccount : IEntity<int>
    {
        public int Id { get; set; }
        public decimal Money { get; set; }
    }
}
