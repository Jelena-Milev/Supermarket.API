using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<IEnumerable<Category>> ListAsync()
        {
            return null;
        }
    }
}
