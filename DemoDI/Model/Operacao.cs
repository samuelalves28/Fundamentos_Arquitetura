using DemoDI.Implementations.Interface.LifeCycle;

namespace DemoDI.Model;

public class Operacao : IOperacaoTransient, IOperacaoScoped, IOperacaoSingleton, IOperacaoSingletonInstance
{
    public Operacao() : this(Guid.NewGuid())
    {
    }

    public Operacao(Guid guid) => OperacaoId = guid;

    public Guid OperacaoId { get; private set; }
}
