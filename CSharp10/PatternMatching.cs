namespace PlaygroundCSharp.CSharp10;

public class PatternMatching
{
    public void MyMethod()
    {
        var person = new Person
        {
            BirthDate = new DateTime(1990, 10, 12)
        };
    }

    public void Process(Person p)
    {
        // C# 10
        if (p is { BirthDate.Year: 1990 })
        {

        }
    }
}


public class Person
{
    public DateTime BirthDate { get; set; }
}