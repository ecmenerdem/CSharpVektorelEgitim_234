namespace Inheritance
{
  public class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ayşe","Fatma","asd@asd.com");

            Employee employee1 = new Employee(6) {};
            Employee employee2 = new Employee(10) { };
            Employee employee3 = new Employee(8) { };
            Employee employee4 = new Employee(15) { };
            Employee employee5 = new Employee(1) { };

           
            List<Employee> list = new List<Employee>();

                list.Add(employee1);
                list.Add(employee2);
                list.Add(employee3);
                list.Add(employee4);
                list.Add(employee5);

            //PartTimeEmployee part = new PartTimeEmployee();
            //part.FirstName = "PART";
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();

            //list.Add(fullTimeEmployee);
            //list.Add(part);



            foreach (Employee emp in list)
            {
                //if (emp.GetType()==typeof(PartTimeEmployee))
                //{
                //    Console.WriteLine(emp.FirstName);
                //}

                if (emp.Experience >= 5)
                {
                    emp.Salary = Convert.ToInt32(emp.Salary * 1.20);
                }

                Console.WriteLine(emp.Salary);
            }
            

            //User user1 = new User
            //{
            //    FirstName = "Ali",
            //    LastName = "Veli"
            //};

            // User user3 = new User("Ecmen", "Erdem");

            //Console.WriteLine(user.GetFullName());
            //Console.WriteLine(user.GetDetail());



        }
    }

  


}
