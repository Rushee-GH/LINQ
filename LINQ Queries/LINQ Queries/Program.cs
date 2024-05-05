using LINQ_Queries;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                EmpId = 1,
                Name = "Sachin",
                Age = 35,
                Gender = 'M',
                Salary = 106000
            },
            new Employee()
            {
                EmpId = 2,
                Name = "Amol",
                Age = 32,
                Gender = 'M',
                Salary = 20000
            },
            new Employee()
            {
                EmpId = 3,
                Name = "Tejas",
                Age = 29,
                Gender = 'M',
                Salary = 0
            },
            new Employee()
            {
                EmpId = 4,
                Name = "Akash",
                Age = 27,
                Gender = 'M',
                Salary = 0
            },
            new Employee()
            {
                EmpId = 5,
                Name = "Shubham",
                Age = 25,
                Gender = 'M',
                Salary = 15000
            },
            new Employee()
            {
                EmpId = 6,
                Name = "Rushikesh",
                Age = 24,
                Gender = 'M',
                Salary = 37000
            }
        };


        var basicQuery = employees.Select((rec, index) => new { index, rec.EmpId, rec.Salary});

        foreach (var item in basicQuery)
        {
            Console.WriteLine(item);
        }
        //foreach (var item in basicQuery)
        //{
        //    Console.WriteLine(string.Format("Id : {0}\nName : {1}\nGender : {2}\nAge : {3}\nSalary : {4}", item.EmpId, item.Name, item.Gender, item.Age, item.Salary));
        //    Console.WriteLine("--------------");
        //}

    }
}