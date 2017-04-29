using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityValidation
{
   public class Employee:EntityBase
   {
     
        public Employee(string position,double salary)
        {
            this.Position = position;
            this.Salary = salary;
           
        }

        public string Position { get; private set; }
        public double Salary { get; private set; }

        public override bool IsValid()
        {
            if (!new EmployeeValidator(this).Validate().Any())
            {
                return true;
            }
            return false;
        }
    }
}
