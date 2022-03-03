namespace PlaygroundCSharp.CSharp10;

public class Productivity
{
    public const string CONSTANT = "Constant"; // defined in compilation 
    public const string CONSTANT2 = CONSTANT + "_Constant";

    // C# 10
    public const string CONSTANT3 = $"{CONSTANT}_Constant"; // interpolation in constant
    public static readonly string ReadOnly = "ReadOnly"; // defined in execution


    public void MyMethod()
    {
        // C# 10 => lambda, useful in minimal api
        var func = () => "Hello World";
        var func2 = string () => null;


        var p = new MyPerson { FirstName = "Mehmet", LastName = "Cinar" };
        (string firstName, string lastName) = p;
        Console.WriteLine(lastName + " " + firstName);

        // C# 10
        string lastName2 = "CINAR";
        (lastName2, string firstName2) = p;
        Console.WriteLine(lastName2 + " " + firstName2);
    }
}

public class MyPerson 
{
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public void Deconstruct(out string firstName, out string lastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }
}
