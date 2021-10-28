using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayrollServices
{
    class EmployeeRepo
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Payroll_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployee()
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel();

                using (this.connection)
                    {
                        string query = @"Select EmployeeID,EmployeeName,EmployeeAge,EmployeeAddress,Gender,EmployeeSalary,ModifiedDate from EmployeeTable1";
                        SqlCommand cmd = new SqlCommand(query, this.connection);
                        this.connection.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        
                        if(dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employeeModel.EmployeeID = dr.GetInt32(0);
                            employeeModel.EmployeeName = dr.GetString(1);
                            employeeModel.EmployeeAge = dr.GetInt32(2);
                            employeeModel.EmployeeAddress = dr.GetString(3);
                            employeeModel.Gender = dr.GetString(4);
                            employeeModel.EmployeeSalary = dr.GetInt32(5);
                            employeeModel.ModifiedDate = dr.GetDateTime(6);

                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", employeeModel.EmployeeID, employeeModel.EmployeeName, employeeModel.EmployeeAge, employeeModel.EmployeeAddress, employeeModel.Gender, employeeModel.EmployeeSalary, employeeModel.ModifiedDate);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    dr.Close();



                    }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public bool AddEmployee(EmployeeModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmploeeID", model.EmployeeID);
                    command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    command.Parameters.AddWithValue("@EmployeeAge", model.EmployeeAge);
                    command.Parameters.AddWithValue("@EmployeeAdress", model.EmployeeAddress);
                    command.Parameters.AddWithValue("@Gender", model.Gender);
                    command.Parameters.AddWithValue("@EmployeeSalary", model.EmployeeSalary);
                    command.Parameters.AddWithValue("@ModifiedDate", model.ModifiedDate);

                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }

    }
}
