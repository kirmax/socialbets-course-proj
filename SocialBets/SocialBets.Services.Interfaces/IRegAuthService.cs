using System;
using System.Collections.Generic;
using System.Text;

namespace SocialBets.Services.Interfaces
{
   public interface IRegAuthService
    {
        bool RegUser();
        bool AuthUser();
    }
}
