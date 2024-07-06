using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_API
{
    public class ManagerEmployee : Employee
    {
        public override string GetEmployeeType()
        {
            return "Manager Employee";
        }
        public override string GetSalary()
        {
            return "1000";
        }
       
    }
}
