namespace PlaygroundCSharp.CSharp8;

// < C# 8
public class Dispo : IDisposable
{
    public void Dispose()
    {
        Task.Delay(1000).GetAwaiter().GetResult();
    }
}

// C# 8 : if you need to call async method in dispose method
public class AsyncDispo : IAsyncDisposable
{
    public async ValueTask DisposeAsync()
    {
        await Task.Delay(1000);
    }
}

class AsyncDisposable
{
    public async Task MyMethod()
    {
        await using (var dispo = new AsyncDispo())
        {

        }
    }
}