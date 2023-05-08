using Microsoft.EntityFrameworkCore;
using EmlakAPI_V2.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlakAPI_V2.Application.Repositories;
using EmlakAPI_V2.Persistence.Repositories;

namespace EmlakAPI_V2.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EmlakAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<ICommentReadRepository, CommentReadRepository>();
            services.AddScoped<ICommentWriteRepository, CommentWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductPropertyReadRepository, ProductPropertyReadRepository>();
            services.AddScoped<IProductPropertyWriteRepository, ProductPropertyWriteRepository>();
            services.AddScoped<IProductTypeReadRepository, ProductTypeReadRepository>();
            services.AddScoped<IProductTypeWriteRepository, ProductTypeWriteRepository>();
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
        }
    }
}
