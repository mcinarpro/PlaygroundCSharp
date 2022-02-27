namespace PlaygroundCSharp.CSharp9;

public class PatternMatching
{
    public void MyMethod()
    {
        object a = null;
        // C# < 9
        if (a == null)
        {
            Console.WriteLine("a is null");
        }

        if (a is null)
        {
            Console.WriteLine("a is null");
        }

        // C# 9
        if (a is not null)
        {
            Console.WriteLine("a is not null");
        }

        decimal d = 20m;
        var x = d switch
        {
            < 10 => "less than 10",
            >= 11 and < 20  => "greater or equals 11 and less than 20",
            >= 41 or >= 51  => "greater or equals 41 and greater or equals 51",
            _ => "default"
        };
    }
}