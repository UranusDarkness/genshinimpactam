﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinImpactAccountManager
{
    public interface ICancelHandler
    {
        void FiveStarsCanceled();
        void FourStarsCanceled();

    }
}
