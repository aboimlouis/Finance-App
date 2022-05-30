using FinanceApp.Data;
using FinanceApp.Data.Repositories.Implementations;
using FinanceApp.Data.Repositories.Interfaces;
using FinanceApp.Services.Implementations;
using FinanceApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Configurations
{
    public static class ConfigureDI
    {
        public static void AddRepositoryDI(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }

        public static void AddServiceDI(this IServiceCollection services)
        {
            services.AddScoped<IGetCompleteUserService, GetCompleteUserService>();
        }

        public static void AddContextDI(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Context")));
        }
    }
}
