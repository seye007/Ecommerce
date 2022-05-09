using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infrastructure
{
    public static class Extension
    {
        public static void RegisterDBContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                getAssembly => getAssembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                ));
        }
    }
}
