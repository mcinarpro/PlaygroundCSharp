namespace PlaygroundCSharp.CSharp8;

class Address 
{
    public AddressType Type { get; set; }
    public string Street { get; set; }  
    public string ZipCode { get; set; }
    public string Country { get; set; }
}

enum AddressType 
{
    Principal,
    Secondary,
    Other
}

class PatternMatching
{
    // < C# 8
    public Address CreateAddress(string street, string zipCode, string country, AddressType type)
    {
        switch (type)
        {
            case AddressType.Principal:
                return new Address { Type = type, Street = street, ZipCode = zipCode, Country = country };
            default:
                return new Address();
        }
    }

    // C# 8
    public Address CreateAddress2(string street, string zipCode, string country, AddressType type)
        => type switch 
        {
            AddressType.Principal => new Address { Type = type, Street = street, ZipCode = zipCode, Country = country },
            _ => new Address { Type = type, Street = street, ZipCode = zipCode, Country = country }
        };

    public decimal GetTaxAmount(Address address)
        => address switch
        {
            { Country: "France" } => 20m,
            _ => 18m
        };

    public string GetDepartement(string zipCode, string city)
        => (zipCode, city) switch
        {
            ("75000", "Paris") => "Idf",
            ("34000", "Montpellier") => "Herault",
            (_, _) => "Inconnu"
        };

    public bool IsInGuadeloupe(Address address)
        => address switch
        {
            var zipCodeGuadeloupe when zipCodeGuadeloupe.ZipCode.StartsWith("971") => true,
            _ => false
        };
}