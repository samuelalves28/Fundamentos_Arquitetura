using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers.LifeCycle;

[Route("api/adm/life-cycle")]
public class LifeCycleController(Implementations.Service.Operacao operacaoService, Implementations.Service.Operacao operacaoService2) : ControllerBase
{
    /// <summary>
    /// Transient: Um novo objeto é criado toda vez que o serviço é solicitado. Este tempo de vida é apropriado para serviços leves e sem estado, 
    /// pois cada solicitação recebe uma nova instância, mesmo dentro da mesma requisição. Com isso vemos que a cada chamada no operacaoService.OperacaoTransient.OperacaoId
    /// ele vai mudar.
    /// 
    /// Scoped: Uma única instância do serviço é criada por requisição. Isso significa que mesmo que o serviço seja solicitado várias vezes dentro de uma requisição, 
    /// a mesma instância será reutilizada. Este tempo de vida é ideal para serviços que precisam manter estado dentro do escopo de uma única requisição. Sendo assim vemos
    /// que por mais que utilizamos duas services diferentes chmando o OperacaoScoped ele vai ser o mesmo pois ele guarda na memoria para reaproveitar.
    /// 
    /// Singleton: Uma única instância do serviço é criada e compartilhada por toda a aplicação. Essa instância é mantida durante toda a vida útil da aplicação, sendo ideal 
    /// para serviços pesados ou que necessitam compartilhar estado global. Sendo assim quando chama uma vez ele sempre vai ser o mesmo guid.
    /// 
    /// Referência: https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection#service-lifetimes
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
    {
        var texto = $" Primeira instacia, {Environment.NewLine} " +
            $"OperacaoTransient = {operacaoService.OperacaoTransient.OperacaoId} {Environment.NewLine} " +
            $"OperacaoScoped = {operacaoService.OperacaoScoped.OperacaoId} {Environment.NewLine} " +
            $"OperacaoSingleton = {operacaoService.OperacaoSingleton.OperacaoId} {Environment.NewLine} " +
            $"OperacaoSingletonInstance = {operacaoService.OperacaoSingletonInstance.OperacaoId} {Environment.NewLine} ";
        
        var texto2 = $"{Environment.NewLine}{Environment.NewLine} Segunda instacia, {Environment.NewLine} " +
            $"OperacaoTransient = {operacaoService2.OperacaoTransient.OperacaoId} {Environment.NewLine} " +
            $"OperacaoScoped = {operacaoService2.OperacaoScoped.OperacaoId} {Environment.NewLine} " +
            $"OperacaoSingleton = {operacaoService2.OperacaoSingleton.OperacaoId} {Environment.NewLine} " +
            $"OperacaoSingletonInstance = {operacaoService2.OperacaoSingletonInstance.OperacaoId} {Environment.NewLine} ";

        var response = texto + texto2;
        return Ok(response);
    }
}
