﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
