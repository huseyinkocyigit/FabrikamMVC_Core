﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Role:IEntity
    {
        public int RoleId { get; set; }
        public string RoleAd { get; set; }
    }
}
