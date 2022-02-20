namespace PlaygroundCSharp.CSharp8;

class NullableReferenceType 
{
    // < C# 8
    public int? NullableValue { get; set; }
    public string NullableString { get; set; }

    // C# 8
    #nullable enable // or in csproj <Nullable>Enable</Nullable> for global project
    public string? NullableData { get; set; }
    public string Data { get; set; }

    public NullableReferenceType(string? data)
    {
        // 1 -
        // if (string.IsNullOrEmpty(data)) 
        // {
        //     throw new ArgumentException($"'{nameof(data)}' cannot be null or empty", nameof(data));
        // }
        // OR
        // 2 -
        Data = data!;        
    }

    // OR
    public string Data2 { get; set; } = default!;
    #nullable disable
}