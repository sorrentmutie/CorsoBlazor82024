using DemoLezione.Business;

namespace DemoLezione.Client.Models;

public class MyClientService : IMyInterface
{
    public async Task<string> GetStringAsync()
    {
        await Task.Delay(8000);
        return "Hello from MyClientService!";
    }
}
