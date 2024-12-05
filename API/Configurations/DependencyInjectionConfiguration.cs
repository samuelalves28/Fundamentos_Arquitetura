using API.Implementations.Interfaces;
using API.Implementations.Repositories;
using API.Models;
using infrastructure.Base.Implementations.Interfaces;

namespace API.Injections;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddRepositoryInjections(this IServiceCollection services)
    {
        services.AddScoped<ICadUsuarioRepository, CadUsuarioRepository>();

        return services;
    }
}
