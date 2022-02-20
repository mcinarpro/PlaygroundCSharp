namespace PlaygroundCSharp.CSharp8;

class AsyncStream
{
    public async IAsyncEnumerable<string> GetData()
    {
        for (int i = 0; i < 10; i++)
        {
            await Task.Delay(100);
            yield return i.ToString();
        }
    }

    public async Task ConsumeData()
    {
        await foreach (var item in GetData())
        {
            Console.WriteLine(item);
        }
    }
}