using System;

namespace EmployeePayrollServices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll");

            EmployeeRepo repo = new EmployeeRepo();
            
            EmployeeModel model = new EmployeeModel();

            model.EmployeeID = 666;
            model.EmployeeName = "Sneha";
            model.EmployeeAge = 24;
            model.EmployeeAddress = "Nashik";
            model.EmployeeSalary = 35000;
            model.Gender = "F";
            model.ModifiedDate = Convert.ToDateTime("2021-10-25 20:50:42.773");

            repo.AddEmployee(model);
            //repo.GetAllEmployee();
            

        }
    }
}
