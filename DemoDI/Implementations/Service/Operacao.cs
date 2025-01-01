using DemoDI.Implementations.Interface.LifeCycle;

namespace DemoDI.Implementations.Service;

public class Operacao(IOperacaoTransient operacaoTransient, IOperacaoScoped operacaoScoped, IOperacaoSingleton operacaoSingleton, IOperacaoSingletonInstance operacaoSingletonInstance)
{
    public IOperacaoTransient OperacaoTransient { get; } = operacaoTransient;
    public IOperacaoScoped OperacaoScoped { get; } = operacaoScoped;
    public IOperacaoSingleton OperacaoSingleton { get; } = operacaoSingleton;
    public IOperacaoSingletonInstance OperacaoSingletonInstance { get; } = operacaoSingletonInstance;
}
