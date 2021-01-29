﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitcoinBlockexplorer.Services.Interfaces
{
    public interface IBlockExplorerService
    {
        Task<string> GetRawTransaction(string methodName, List<string> parameters);
    }
}
