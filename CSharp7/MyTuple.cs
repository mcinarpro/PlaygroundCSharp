namespace PlaygroundCSharp.CSharp7;

class MyTuple
{
    public void MyMethod()
    {
        var tuple = ("value", 42);
        Console.WriteLine(tuple.Item2);

        var tuple2 = (ValueStr: "value", ValueInt: 42);
        Console.WriteLine(tuple2.ValueInt);

        // C# 7.0
        (string ValueStr, int ValueInt) tuple3 = ("value", 42);
        Console.WriteLine(tuple3.ValueInt);

        // C# 7.1
        string ValueStr = "value";
        int ValueInt = 42;
        var tuple4 = (ValueStr, ValueInt);
        Console.WriteLine(tuple4.ValueInt);

        // C# 7.3
        var tuple5 = ("valeur", 42);
        var tuple6 = ("valeur", 42);

        Console.WriteLine(tuple5 == tuple6 ? "Tuple5 equals tuple6" : "Tuple5 doesn't equal tuple6");

        // Deconstruc class to tuple
        var student = new Student { Name = "John", LastName = "Doe" };
        (string name, string lastName) = student;
        Console.WriteLine($"The student is {name} {lastName}.");
    }
}

public class Student 
{
    public string Name { get; set; } 
    public string LastName { get; set; }

    public void Deconstruct(out string name, out string lastName)
    {
        name = Name;
        lastName = LastName;
    }
}