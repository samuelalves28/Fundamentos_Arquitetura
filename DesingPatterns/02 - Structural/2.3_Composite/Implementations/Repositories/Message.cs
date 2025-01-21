using System.Collections;
using DesingPatterns._02___Structural._2._3_Composite.Implementations.Interfaces;

namespace DesingPatterns._02___Structural._2._3_Composite.Implementations.Repositories;

public class Message : IMessage, IEnumerable<IMessage>
{
    private readonly List<IMessage> _list = [];

    public string Nome { get; set; }


    public Message(string nome)
    {
        Nome = nome;
    }

    public void AdicionarFilha(IMessage message)
    {
        _list.Add(message);
    }

    public void RemoverFilha(IMessage message)
    {
        _list.Remove(message);
    }

    public IMessage ObterFilha(int index)
    {
        return _list[index];
    }

    public IMessage ObterFilha(string nome)
    {
        return _list.FirstOrDefault(x => x.Nome == nome);
    }

    public IEnumerable<IMessage> ObterFilhas()
    {
        return _list;
    }

    public IEnumerator<IMessage> GetEnumerator()
    {
        return ((IEnumerable<IMessage>)_list).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<IMessage>)_list).GetEnumerator();
    }

    public void ExibirMensagens(int sub)
    {
        Console.WriteLine(new string('-', sub) + Nome);

        foreach (var message in _list)
        {
            message.ExibirMensagens(sub + 2);
        }
    }
}
