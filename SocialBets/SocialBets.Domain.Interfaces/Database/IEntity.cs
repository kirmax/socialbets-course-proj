using System;
using System.Collections.Generic;
using System.Text;

namespace SocialBets.Domain.Interfaces.Database
{
    interface IEntity<T>
    {
        public T Id { get; set; }
    }
}
