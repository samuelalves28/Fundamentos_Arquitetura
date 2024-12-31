using DemoDI.Implementations.Interface;
using DemoDI.Implementations.Repository;

namespace DemoDI.Configurations;

public static class DependencyInjectionConfiguration
{
    /// <summary>
    /// Estamos adicionando uma classe ao escopo do projeto, especificando que quando associamos a interface IClienteRepository, utilizamos a implementação ClienteRepository. 
    /// Isso se aplica a qualquer classe. Quando instanciamos a interface, o .NET faz as referências necessárias internamente ao colocarmos no construtor de controllers, repositórios, serviços, etc.
    /// </summary>
    public static IServiceCollection AddInjectionsRepository(this IServiceCollection services)
    {
        services.AddScoped<IClienteRepository, ClienteRepository>();
        return services;
    }
}
