namespace PlaygroundCSharp.CSharp10;

public class ImprovedStruct
{
    public void MyMethod()
    {
        var address = new Address("Place de la comédie", "34000");

        // C# 10
        var address2 = address with { Street = "Place Liedts" };
    }
}


public struct Address 
{
    public string Street { get; init; }
    public string PostalCode { get; init; }

    public Address(string street, string postalCode)
    {
        Street = street;
        PostalCode = postalCode;
    }

    // C# 10
    public Address()
    {
        Street = "Rue Quoesimodes";
        PostalCode = "4540";
    }
}