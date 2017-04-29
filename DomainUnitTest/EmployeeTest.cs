using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTest
{
    [TestClass]
   public class EmployeeTest
    {
        [TestMethod]
        public void Employee_Should_Contain_Errors()
        {
            var employee = new Employee("CEO", 2000000);
          bool isValid=   employee.IsValid();

        }
    }
}
