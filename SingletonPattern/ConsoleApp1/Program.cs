using ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        Parallel.Invoke(
            ()=> PrintEmployee1Detail(),
            ()=> PrintEmployee2Detail()
            );

        Console.ReadLine();
        // why we should use sealed keyword
        Console.WriteLine("------------------------------------------");
        //the counter value will increase
        //Employee.DerivedEmployee derivedEmployee = new Employee.DerivedEmployee();
        //Employee.DerivedEmployee derivedEmployee1 = new Employee.DerivedEmployee();

        //derivedEmployee.PrintDetails("derived 1");
        //derivedEmployee.PrintDetails("derived 2");
    }

    private static void PrintEmployee2Detail()
    {
        Employee employee1 = Employee.GetInstance;
        employee1.PrintDetails("emp 2 details");
    }

    private static void PrintEmployee1Detail()
    {
        Employee employee = Employee.GetInstance;
        employee.PrintDetails("emp 1 details");
    }
}