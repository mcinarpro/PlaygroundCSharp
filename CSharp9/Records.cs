namespace PlaygroundCSharp.CSharp9;

public class Class1
{
    public string Data { get; init; }
    public int Value { get; init; }
    public DateTime Date { get; set; }
}

// C# 9
public record Record1
{
    public string Data { get; init; }
    public int Value { get; init; }
    public DateTime Date { get; set; }
}

class RecordsTest
{
    void MyMethod()
    {
        var c1 = new Class1 { Data = "Toto", Value = 42, Date = DateTime.UtcNow };
        var c2 = new Class1 { Data = "Toto", Value = 42, Date = DateTime.UtcNow };
        c1.Equals(c2); // false => ReferenceEquals
        
        // C# 9
        var c3 = new Record1 { Data = "Toto", Value = 42, Date = DateTime.UtcNow };
        var c4 = new Record1 { Data = "Toto", Value = 42, Date = DateTime.UtcNow };
        c3.Equals(c4); // true => record is immutable, when created we cannot change so equals check only values

        var c5 = c3 with { Value = 43 };
    }
}