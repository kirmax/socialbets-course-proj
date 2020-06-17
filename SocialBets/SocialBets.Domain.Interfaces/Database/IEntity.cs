﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SocialBets.Domain.Interfaces.Database
{
    interface IEntity<T>
        where T : struct
    {
        public T Id { get; set; }
    }
}
