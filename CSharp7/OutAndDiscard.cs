namespace PlaygroundCSharp.CSharp7;

class OutAndDiscard
{
    public void MyParseMethod(string value)
    {
        // Inline out
        if (int.TryParse(value, out var integer)) {
            Console.WriteLine($"Value is an integer ({integer})");
        }
        Console.WriteLine($"Value is an integer ({integer})");

        
        // Out and Discard
        if (int.TryParse(value, out var _)) {
            Console.WriteLine($"Value is an integer");
        }
    }
}