using Microsoft.AspNetCore.Identity;
using SocialBets.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialBets.Services.Interfaces
{
   public interface IAccountService
    {
        Task<IdentityResult> Register(ApplicationUser user);
        Task<bool> Login(ApplicationUser user);
        Task<bool> isUserExists(ApplicationUser user);
        Task<bool> ResetPassword(ApplicationUser user);
    }
}
