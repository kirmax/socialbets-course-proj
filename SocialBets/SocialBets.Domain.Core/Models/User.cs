using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialBets.Domain.Core.Models
{
    public class User : IdentityUser
    {
        public string ImagePath { get; set; }
        public MoneyAccount MoneyAccountId { get; set; }
        public UserInfo UserInfoId { get; set; }
        public Statistics StatisticsId { get; set; }
    }
}
