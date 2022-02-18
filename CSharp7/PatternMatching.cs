namespace PlaygroundCSharp.CSharp7;

public class PatternMatching
{
    public void MyMethod(object a) 
    {
        // < C# 7
        if (a is DateTime)
        {
            var aAsDateTime = (DateTime)a;
            Console.WriteLine($"DateTime : {aAsDateTime}");
        }
        else if (a is string)
        {
            var aAsString = a as string;
            Console.WriteLine($"String : {aAsString}");
        }

        // C# 7 
        if (a is DateTime aAsDateTime2)
        {
            Console.WriteLine($"DateTime : {aAsDateTime2}");
        }
        else if (a is string aAsString2)
        {
            Console.WriteLine($"String : {aAsString2}");
        }

        switch (a)
        {
            case DateTime aAsDateTime:
                Console.WriteLine($"DateTime : {aAsDateTime}");
                break;
            case string aAsString:
                Console.WriteLine($"String : {aAsString}");
                break;
            case int aAsInt when aAsInt > 42:
                Console.WriteLine($"Int > 42 : {aAsInt}");
                break;
            case null:
                Console.WriteLine($"Null");
                break;
            default:
                break;
        }
    }    
}
