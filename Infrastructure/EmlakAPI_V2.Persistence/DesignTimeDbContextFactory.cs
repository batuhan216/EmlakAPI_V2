using EmlakAPI_V2.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EmlakAPIDbContext>
    {
        public EmlakAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EmlakAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new EmlakAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
