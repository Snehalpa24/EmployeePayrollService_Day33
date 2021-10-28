using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollServices
{
    class EmployeeModel
    {
        
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeAddress { get; set; }
        public string Gender { get; set; }

        public int EmployeeSalary { get; set; }

        public DateTime ModifiedDate { get; set; }



    }
}
