﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Joint
{
    public enum JointStatus
    {
        Undefined = 0,
        AtControl = 1,
        AtIsolation = 2,
        Lowered = 3,
        Filled = 4
    }
}
