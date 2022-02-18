namespace PlaygroundCSharp.CSharp7;
class ThrowException
{
    public void MyMethod(int[] array, string value)
    {
        // C# 6
        if (string.IsNullOrWhiteSpace(value)) 
        {
            throw new ArgumentException();
        }
        string value2 = value;

        // C# 7
        string value3 = value ?? throw new ArgumentException();
        Console.WriteLine(value);

        int firstElement = array.Length >= 1 ? array[0] : throw new InvalidOperationException();
    }
}