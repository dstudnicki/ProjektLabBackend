﻿using ProjektBackendLab.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBackendLab.Core.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Categories> GetAllCategories();
        Categories GetCategoryById(int categoryId);
        bool CategoryExists(int categoryId);
    }
}
