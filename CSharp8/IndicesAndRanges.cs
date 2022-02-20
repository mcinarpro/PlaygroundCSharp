namespace PlaygroundCSharp.CSharp8;

class IndicesAndRanges
{
    public void MyMethod()
    {
        var tab = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var one = tab[0];
        
        // < C# 8
        var last = tab[tab.Length - 1];

        // C# 8
        var last2 = tab[^1];

        var range = tab[1..4]; // index 4 is excluded
        Console.WriteLine("range : " + string.Join(",", range));

        var r = 1..3;
        var range2 = tab[r];        
        Console.WriteLine("range2 : " + string.Join(",", range2));
    }
}