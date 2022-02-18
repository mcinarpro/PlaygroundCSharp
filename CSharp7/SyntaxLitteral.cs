namespace PlaygroundCSharp.CSharp7;

class SyntaxLitteral
{
    public void MyMethod()
    {
        int oneMillion = 1_000_000;
        int oneBillion = 1_000_000_000;

        double myValue = 3.105_203_569;

        int sixteen = 0b0001_0000;

        DateTime date1 = default(DateTime);
        // with C# 7
        DateTime date2 = default;

        Console.WriteLine($"{oneMillion}-{oneBillion}-{myValue}-{sixteen}");
        Console.WriteLine($"Date1 : {date1}");
        Console.WriteLine($"Date2 : {date2}");
    }
}