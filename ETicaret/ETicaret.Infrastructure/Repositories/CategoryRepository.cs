﻿using ETicaret.Domain.Interfaces;
using ETicaret.Domain.Models;
using ETicaret.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRespository
    {
        public CategoryRepository(ETicaretDbContext context) : base(context)
        {

        }
    }
}
