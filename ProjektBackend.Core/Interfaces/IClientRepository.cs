﻿using ProjektBackendLab.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBackendLab.Core.Interfaces
{
    public interface IClientRepository
    {
        void AddClient(Clients client);
    }
}
