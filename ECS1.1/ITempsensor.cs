﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS1._1
{
    public interface ITempsensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}
