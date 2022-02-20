namespace PlaygroundCSharp.CSharp8;

interface ILogger
{
    void Log(string message);
    void LogWarning(string warning) => Log("Warning : " + warning);
}

class Logger : ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}

class MyClass
{
    public void Log(ILogger logger)
    {
        logger.Log("log");
    }
}