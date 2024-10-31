using DemoLezione.Business;

namespace DemoLezione.Services;

public class MyServerService : IMyInterface
{
    public async Task<string> GetStringAsync()
    {
        await Task.Delay(5000);
        return "Hello from MyServerService!";
    }
}
