internal class Program
{
    private static void Main(string[] args)
    {
        List <int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            
        // Query Syntax
        var qresult = from rec in list
                     where rec % 2 == 0
                     select rec * rec;

        foreach (var item in qresult)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("----------------------------------------");

        // Method Syntax
        var mresult = list.Where(rec => rec % 2 == 0);
        foreach (var item in mresult)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("----------------------------------------");

        // Mixed Syntax
        var mxresult = (from rec in list
                        select rec).Where(rec => Math.Sqrt(rec) * Math.Sqrt(rec) == rec); // Returns Perfect squares
        foreach (var item in mxresult)
        {
            Console.WriteLine(item);
        }
    }
}