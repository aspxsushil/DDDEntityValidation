using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityValidation
{
     public class EmployeeValidator:Validator
     {
        private Employee employee;


         public EmployeeValidator(Employee employee)
         {
             this.employee = employee;
         }

        public override IList<string> Validate()
        {
            if (this.HasPositionSalaryMismatch())
            {
               Errors.Add("Position and Salary Mismatch");
            }
            return Errors;
        }

         public bool HasPositionSalaryMismatch()
         {
             return employee.Salary > 90000 && !employee.Position.Equals("SDEIII");
            
         }
    }
}
