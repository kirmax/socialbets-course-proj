using System;
using System.Collections.Generic;
using System.Text;

using SocialBets.Domain.Core.Interfaces;

namespace SocialBets.Domain.Core.Models
{
    enum SocialNetworkType 
    {
        TikTok, Instagram
    }
    class SocialNetwork : IEntity<int>
    {
        public int Id { get; set; }
        public SocialNetworkType Type { get; set; }
    }
}
