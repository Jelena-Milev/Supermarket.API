﻿using Supermarket.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();         
    }
}
