class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}


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

        Console.WriteLine("----------------------------------------");

        List<Employee> emp = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                Name = "Sachin",
                Salary = 106000,
            },
            new Employee()
            {
                Id = 2,
                Name = "Amol",
                Salary = 20000
            },
            new Employee()
            {
                Id = 3,
                Name = "Tejas",
                Salary = 0
            },
            new Employee()
            {
                Id = 4,
                Name = "Akash",
                Salary = 0
            },
            new Employee()
            {
                Id = 5,
                Name = "Shubham",
                Salary = 16000
            },
            new Employee()
            {
                Id = 6,
                Name = "Rushi",
                Salary = 37000
            }
        };

        IEnumerable<Employee> filter = (from rec in emp
                                       where rec.Salary != 0
                                       select rec);

        foreach (var item in filter)
        {
            Console.WriteLine(string.Format("Id : {0}, Name : {1}, Salary : {2}", item.Id, item.Name, item.Salary));
        }

        Console.WriteLine("----------------------------------------");

        IQueryable<Employee> filter1 = (from rec in emp
                                        where rec.Salary == 0
                                        select rec).AsQueryable();

        foreach (var item in filter1)
        {
            Console.WriteLine(string.Format("Id : {0}, Name : {1}, Salary : {2}", item.Id, item.Name, item.Salary));
        }
    }
}