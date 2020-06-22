using System;
using System.Collections.Generic;
using System.Text;

using SocialBets.Domain.Core.Interfaces;

namespace SocialBets.Domain.Core.Models
{
    enum OperationType
    {
        Income, Withdrawal, Bet
    }

    class Operation : IEntity<int>
    {
        public int Id { get; set; }
        public OperationType Type { get; set; }

    }
}
