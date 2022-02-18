namespace PlaygroundCSharp.CSharp7;

class BodiedMembers
{
    // C# 6
    public void Write(string value) => Console.WriteLine(value);
    public int Value => 4;

    private string myValue;
    // C# 7
    public string MyValue
    {
        get => myValue;
        set => myValue = value;
    }

    public BodiedMembers() => MyValue = "42";

    ~BodiedMembers() => MyValue = "";

}