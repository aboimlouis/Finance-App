using FinanceApp.Domain.Profiles.Group;
using FinanceApp.Domain.Profiles.Tag;
using System.Reflection;

namespace FinanceApp.Configurations
{
    public static class ConfigureAutoMapper
    {
        public static void ConfigureAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(GroupProfile)));
            services.AddAutoMapper(Assembly.GetAssembly(typeof(TagProfile)));
        }
    }
}
