namespace DesingPatterns._01___Creational._1._3_Singleton;

internal sealed class LoadBalancer
{
    private static readonly LoadBalancer Instace = new LoadBalancer();

    private readonly List<Server> _servers;
    private readonly Random _random = new Random();

    private LoadBalancer()
    {
        _servers = new List<Server>
        {
            new(){Name = "ServerI", IPAddress ="120.14.220.18"},
            new(){Name = "ServerII", IPAddress ="120.14.220.19"},
            new(){Name = "ServerIII", IPAddress ="120.14.220.20"},
            new(){Name = "ServerIIII", IPAddress ="120.14.220.21"},
            new(){Name = "ServerIIIII", IPAddress ="120.14.220.22"},
        };
    }

    public static LoadBalancer GetLoadBalancer()
    {
        return Instace;
    }

    public Server NextServer
    {
        get
        {
            var r = _random.Next(_servers.Count);
            return _servers[r];
        }
    }
}
