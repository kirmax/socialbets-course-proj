using System;
using System.Collections.Generic;
using System.Text;

namespace SocialBets.Services.Interfaces
{

    /// <summary>
    /// Point represent money
    /// </summary>
    
    interface IMoneyService
    {
        void MoneyToPoints();
        void PointsToMoney();
    }
}
