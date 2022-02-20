namespace PlaygroundCSharp.CSharp8;

// C# 7.2 : completely immutable type
readonly struct ReadonlyStruct
{
    public int Val1 { get; }
    public int Val2 { get; }
    public int Result => Val1 + Val2;

    public ReadonlyStruct(int val1, int val2)
    {
        Val1 = val1;
        Val2 = val2;
    }
}

// C# 8 : mutable type with readonly query
struct ReadonlyStruct2
{
    public int Val1 { get; set; }
    public int Val2 { get; set; }
    public readonly int Result => Val1 + Val2;
    
    // add readonly because it's a query
    public readonly override string ToString()
    {
        return $"{Val1} + {Val2} = {Result}";
    }
}