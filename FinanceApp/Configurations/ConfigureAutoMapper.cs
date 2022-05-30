using FinanceApp.Domain.Profiles.Character;
using System.Reflection;

namespace FinanceApp.Configurations
{
    public static class ConfigureAutoMapper
    {
        public static void ConfigureAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(CharacterProfile)));
        }
    }
}
