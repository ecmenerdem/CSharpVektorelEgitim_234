﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_API
{
    public class FullTimeEmployee : Employee
    {
        public override string GetEmployeeType()
        {
            return "Full Time Employee";
        }
        public override string GetSalary()
        {
            return "500";
        }
    }
}
