﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Fireblocks.Entities;

namespace Fireblocks
{
    public interface IFireblocks
    {
        Task<List<VaultAccount>> GetVaults();
    }
}
