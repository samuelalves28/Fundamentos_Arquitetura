using DemoDI.Implementations.Interface;
using DemoDI.Implementations.Interface.LifeCycle;
using DemoDI.Implementations.Repository;
using DemoDI.Model;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Configurations;

public static class DependencyInjectionConfiguration
{
    /// <summary>
    /// Estamos adicionando uma classe ao escopo do projeto, especificando que quando associamos a interface IClienteRepository, utilizamos a implementação ClienteRepository. 
    /// Isso se aplica a qualquer classe. Quando instanciamos a interface, o .NET faz as referências necessárias internamente ao colocarmos no construtor de controllers, repositórios, serviços, etc.
    /// O aplicativo de exemplo registra o IClienteRepository com o tipo concreto ClienteRepository. O método AddScoped registra o serviço com um tempo de vida com escopo, 
    /// o tempo de vida de uma única solicitação. Os tempos de vida do serviço são descritos mais adiante neste tópico.
    /// </summary>
    public static IServiceCollection AddInjectionsRepository(this IServiceCollection services)
    {

        #region LifeCycle

        services.AddTransient<IOperacaoTransient, Operacao>();
        services.AddScoped<IOperacaoScoped, Operacao>();
        services.AddSingleton<IOperacaoSingleton, Operacao>();
        services.AddSingleton<IOperacaoSingletonInstance>(new Operacao(Guid.Empty));
        services.AddTransient<Implementations.Service.Operacao>();

        #endregion

        #region Vida real

        services.AddScoped<IClienteRepository, ClienteRepository>();

        #endregion


        #region Generics

        //Aqui podemos fazer também com que um repositorio especifico herde de um generico.
        services.AddScoped(typeof(IGenericBaseRepository<>), typeof(GenericBaseRepository<>));

        #endregion

        return services;
    }
}
