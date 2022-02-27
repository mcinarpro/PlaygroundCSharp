namespace PlaygroundCSharp.CSharp9;

// < C# 8
public class PropertyInitilizer
{
    public int MyProperty { get; }     
    public int MyProperty2 { get; private set; }

    public PropertyInitilizer(int myProperty)
    {
        MyProperty = myProperty;
    }

    public void MyMethod()
    {
        MyProperty2 = 10;
    }
}

// C# 9
public class PropertyInitilizerNew
{
    public int MyProperty { get; init; }
}

class PropertyInitilizerTest 
{
    void MyMethod()
    {
        var propertyInitilizer = new PropertyInitilizer(5); // Readonly with ctor

        var propertyInitilizer2 = new PropertyInitilizerNew { MyProperty = 10 }; // Readonly with initializer        
    }
}