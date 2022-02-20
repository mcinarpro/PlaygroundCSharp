namespace PlaygroundCSharp.CSharp8;

class Productivity
{
    public class Disposable : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public void MyMethod()
    {
        // < C# 8
        using (var dispo = new Disposable())
        {
            
        } //dispose here

        // C# 8
        using var dispo2 = new Disposable();


        // > C# 8
        int? i1 = null;
        int? i2 = 1;

        int? i3 = i1 ?? i2;

        // C# 8
        i1 ??= 17; // if i1 is null => i1 = 17 else i1 keep its value


        // C# 6
        var name = "Snoopy";
        var s = $@"My dog's name is {name} 
        blabla";

        // C# 8 
        var s2 = @$"My dog's name is {name} 
        blabla"; // @ order no longer matters

    } // dispose here
}