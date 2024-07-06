using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        public Employee(int experience)
        {
            Experience = experience;

            if (experience >=5 && experience <10)
            {
                Salary = 500;
            }
            else if(experience >= 10) 
            {
                Salary = 1000;

            }
            else { Salary = 100; }
        }

        public int Salary { get; set; }
        public int Experience { get; set; }


        public int GetSalaryPerMonth()
        {
            return 40;
        }

    }
}
