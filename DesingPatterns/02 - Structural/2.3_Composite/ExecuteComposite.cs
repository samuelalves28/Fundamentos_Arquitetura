using DesingPatterns._02___Structural._2._3_Composite.Implementations.Repositories;
using DesingPatterns._02___Structural._2._3_Composite.Implementations;
namespace DesingPatterns._02___Structural._2._3_Composite;

public class ExecuteComposite
{
    public static void Executar()
    {
        var validacaoCadastro = new Message(nome: "O cadastro não foi realizado!");

        var usuarioFormErro = new Message(nome: "O usuario informou um nome invalido");

        var tamanhoNomeForm = new InputFormMessage(nome: "O nome precisa possuir mais de 2 caracteres");
        var nomeVazioForm = new InputFormMessage(nome: "O nome nao pode possuir numeros");

        usuarioFormErro.AdicionarFilha(tamanhoNomeForm);
        usuarioFormErro.AdicionarFilha(nomeVazioForm);

        validacaoCadastro.AdicionarFilha(usuarioFormErro);

        var domainUsuarioErro = new Message(nome: "Problemas ao processar o cadastro de usuario");

        var cpfUsuarioDomain = new DomainMessage(nome: "O CPF informado está em uso!");
        var emailUsuarioDomain = new DomainMessage(nome: "O Email informado esta em uso!");

        domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
        domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);

        validacaoCadastro.AdicionarFilha(domainUsuarioErro);

        validacaoCadastro.ExibirMensagens(2);
    }
}
