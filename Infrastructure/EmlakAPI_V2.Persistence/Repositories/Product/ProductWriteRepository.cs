﻿using EmlakAPI_V2.Application.Repositories;
using EmlakAPI_V2.Domain.Entities;
using EmlakAPI_V2.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(EmlakAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
