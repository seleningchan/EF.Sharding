﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Sharding
{
    public interface IShardingPolicyProvider
    {
        string GetShardingSuffix();
    }
}
