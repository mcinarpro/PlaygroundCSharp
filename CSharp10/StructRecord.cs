namespace PlaygroundCSharp.CSharp10;

public class RecordTest
{
    public void MyMethod()
    {
        var r = new MyRecord("Test");

        // C# 10
        var sr = new MyStructRecord(); // defaut ctor available
    }
}

// C# 9 class record by default
public record MyRecord(string value);

// C# 10 struct record available
public record struct MyStructRecord(string value);

