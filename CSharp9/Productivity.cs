using System.Text;

namespace PlaygroundCSharp.CSharp9;

public class Productivity
{
    public void MyMethod()
    {
        // <C #9
        var sb = new StringBuilder("test");

        // C# 9
        StringBuilder sb2 = new("test");
        Vehicle vehicle = new() { Type = "BMW" };

        var i = 10;
        Func<int, int> square = static n => n * n; // static keyword
        square(i);

        var garage = new Garage { Vehicles = new List<Vehicle> { vehicle, new Vehicle { Type = "Mercedes" } } };
        foreach (var v in garage) // without implementing IEnumerable in garage class
        {
            Console.WriteLine("Vehicle : " + v.Type);
        }

    }
}

public static class GarageExtensions
{
    public static IEnumerator<Vehicle> GetEnumerator(this Garage garage)
    {
        return garage.Vehicles.GetEnumerator();
    }
}

public class Vehicle
{
    public string Type { get; set; }
}

public class Garage
{
    public List<Vehicle> Vehicles { get; set; }
}