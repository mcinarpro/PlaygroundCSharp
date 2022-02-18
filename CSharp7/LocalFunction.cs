namespace PlaygroundCSharp.CSharp7;

public class LocalFunction
{
    public void MyMethod(string value1, string value2) 
    {
        // < C# 7
        if (!value1.EndsWith("s"))
        {
            value1 += "s";
        }
        if (!value2.EndsWith("s"))
        {
            value2 += "s";
        }

        // C# 7
        string PutInPlural(string value)
        {            
            if (!value.EndsWith("s"))
            {
                value += "s";
            }

            return value;
        }

        value1 = PutInPlural(value1);
        value2 = PutInPlural(value2);
        Console.WriteLine($"value1 : {value1} - value2 : {value2}");
    }    
}
