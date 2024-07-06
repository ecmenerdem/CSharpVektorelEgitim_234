using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace OOP_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            var result = client.GetAsync("https://northwind.vercel.app/api/employess").Result;

            var jsonString = result.Content.ReadAsStringAsync().Result;

            var allEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);/*API dan gelen Ham veri*/

            ProjectBasedEmployee projectBasedEmployee = new()
            {
                firstName = "Ali",
                lastName = "Veli",
                id = 10,
                
            };


          
            List<Employee>employees = new List<Employee>();/*Sınıflara Ayrılmış Employee ların toplandığı liste*/

           
            foreach (var employee in allEmployees)
            {
               
                if (Convert.ToInt32(employee.reportsTo)==2)
                {
                    FullTimeEmployee fullTimeEmployee = new()
                    {
                        firstName = employee.firstName,
                        lastName = employee.lastName,
                        title = employee.title,
                        reportsTo = Convert.ToInt32(employee.reportsTo) //
                    };

                    employees.Add(fullTimeEmployee);
                }
                else if (Convert.ToInt32(employee.reportsTo) == 5)
                {
                    PartTimeEmployee partTimeEmployee = new()
                    {
                        firstName = employee.firstName,
                        lastName = employee.lastName,
                        title = employee.title,
                        reportsTo = Convert.ToInt32(employee.reportsTo)

                    };
                    employees.Add(partTimeEmployee);
                }
                else
                {
                    ManagerEmployee managerEmployee = new()
                    {
                        firstName = employee.firstName,
                        lastName = employee.lastName,
                        title = employee.title,
                        reportsTo = Convert.ToInt32(employee.reportsTo)

                    };
                    employees.Add(managerEmployee);

                }

            }

            employees.Add(projectBasedEmployee);

            foreach (var employee in employees)
            {
                var reportsTo = allEmployees.Where(q => q.id == Convert.ToInt32(employee.reportsTo)).FirstOrDefault();

                string reportsToFullName = "";

                string employeeType = "";

                Console.WriteLine("First Name: " + employee.firstName);
                Console.WriteLine("Last Name: " + employee.lastName);
                Console.WriteLine("Title: " + employee.title);
                Console.WriteLine("Employee Type: " + employee.GetEmployeeType());
                Console.WriteLine("Salary: " + employee.GetSalary());


               
                reportsToFullName = employee.getReportsTo(reportsTo);


                //Reflection İle Dinamik instance ve dinamik olarak metot çağırma işlemi

                //var type = employee.GetType();
                //var mymethod = type.GetMethod("getReportsTo");
                //var obj =  Activator.CreateInstance(type);
                //var asd = mymethod.Invoke(obj, null);

                //Buraya Yeni Kod Eklendi.

              var sonuc =  Math.Pow(10, 4);


                Console.WriteLine("Reports To: " + reportsToFullName);
                Console.WriteLine("---------------------------");
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
