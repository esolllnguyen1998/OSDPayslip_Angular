﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OSDPayslip.Models.Abstract
{
    public enum Status
    {
        ready = 0,
        pending = 1,
        success = 2,
        fail = -1
    }
}
