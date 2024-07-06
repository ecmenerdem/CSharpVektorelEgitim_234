using static Delegate1.Program;

namespace Delegate1
{
    public class Program
    {
        public delegate bool IsPromotableDelegateHandler(Employee employee);

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee emp1 = new() { Name="Ayşe", Experience=3, Salary=100 };
            Employee emp2 = new() { Name="Ali", Experience=5, Salary=300 };
            Employee emp3 = new() { Name="Veli", Experience=4, Salary=150 };
            Employee emp4 = new() { Name="Fatma", Experience=10, Salary=500 };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);



            Func<Employee, bool> GetEmps = (a) => a.Experience > 5;
            Action<Employee> IncSalary = (emp) => emp.Salary = 1000;

            employees.Where(GetEmps);
            employees.Where(q => q.Experience > 5);

            employees.ForEach(IncSalary);

            foreach (Employee emp in employees)
            {
                emp.Salary = 1000;
            }

            IsPromotableDelegateHandler isPromotableDelegateHandler = new IsPromotableDelegateHandler(Employee.IsPromotable);

            Employee.PromoteEmployees(employees, isPromotableDelegateHandler);

            Console.WriteLine("-----------");

            Employee.PromoteEmployees(employees, q => q.Experience >= 5);

            Console.WriteLine("-----------");

            Employee.PromoteEmployees(employees, q => q.Salary < 200);

            Console.WriteLine("-----------");

            Employee.PromoteEmployees(employees, q => q.Name.StartsWith('A'));

        }
    }

    public class Employee()
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public static void PromoteEmployees(List<Employee>employees, IsPromotableDelegateHandler isPromotableDelegateHandler)
        {
            foreach (Employee emp in employees)
            {
                if (isPromotableDelegateHandler(emp))
                {
                    Console.WriteLine($"{emp.Name} Promoted");
                }

            }
        }

        public static bool IsPromotable(Employee employee)
        {
            if(employee.Experience>=5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
