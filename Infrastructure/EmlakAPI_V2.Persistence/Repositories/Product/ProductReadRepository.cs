using EmlakAPI_V2.Application.Repositories;
using EmlakAPI_V2.Domain.Entities;
using EmlakAPI_V2.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(EmlakAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
