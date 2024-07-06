using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_API
{
    public class Employee:User
    {


        private int? _reportsTo;
        public string title { get; set; }
        public double Salary { get; set; }
        public object reportsTo { 
        
            get
            {
                return _reportsTo;
            }
            set
            {
                if (value.ToString()=="NULL")
                {
                    _reportsTo=null;

                }
                else
                {
                    _reportsTo=Convert.ToInt32(value.ToString());
                }
            }
        
        }



        //public abstract string GetEmployeeType();


        public virtual string GetEmployeeType()
        {
            return "Employee";
        }

        public string getReportsTo(Employee? reportsToEmployee)
        {
            if (reportsToEmployee is not null)
            {
                return reportsToEmployee.firstName + " "+ reportsToEmployee.lastName;
            }
            return "";
        }

        public virtual string GetSalary()
        {
            return "100";
        }

    }
}
