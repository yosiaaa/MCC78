using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ConsoleApp2.Context;

namespace ConsoleApp2.Model
{
    public class Employee
    {
        public string Id { get; set; }
        public string NIK { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime HiringDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DepartmentId { get; set; }

        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            using SqlConnection connection = MyConnection.Get();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tb_m_employees";

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var employee = new Employee();

                        employee.Id = reader.GetGuid(0).ToString();
                        employee.NIK = reader.GetString(1);
                        employee.FirstName = reader.GetString(2);
                        employee.LastName = reader.GetString(3);
                        employee.BirthDate = reader.GetDateTime(4);
                        employee.Gender = reader.GetString(5);
                        employee.HiringDate = reader.GetDateTime(6);
                        employee.Email = reader.GetString(7);
                        employee.PhoneNumber = reader.GetString(8);
                        employee.DepartmentId = reader.GetString(9);

                        employees.Add(employee);
                    }

                    return employees;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return new List<Employee>();
        }

        public int InsertEmployees(Employee employee)
        {
            int result = 0;
            using var connection = MyConnection.Get();
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // Command melakukan insert
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO tb_m_employees(nik, first_name, last_name, birthdate, gender, hiring_date, email, phone_number, department_id) VALUES (@nik, @first_name, @last_name, @birthdate, @gender, @hiring_date, @email, @phone_number, @department_id)";
                command.Transaction = transaction;

                // Membuat parameter
                var pNik = new SqlParameter();
                pNik.ParameterName = "@nik";
                pNik.SqlDbType = SqlDbType.VarChar;
                pNik.Size = 50;
                pNik.Value = employee.NIK;

                var pFName = new SqlParameter();
                pFName.ParameterName = "@first_name";
                pFName.SqlDbType = SqlDbType.VarChar;
                pFName.Size = 50;
                pFName.Value = employee.FirstName;

                var pLName = new SqlParameter();
                pLName.ParameterName = "@last_name";
                pLName.SqlDbType = SqlDbType.VarChar;
                pLName.Size = 50;
                pLName.Value = employee.LastName;

                var pBDate = new SqlParameter();
                pBDate.ParameterName = "@birthdate";
                pBDate.SqlDbType = SqlDbType.DateTime;
                pBDate.Value = employee.BirthDate;

                var pGender = new SqlParameter();
                pGender.ParameterName = "@gender";
                pGender.SqlDbType = SqlDbType.VarChar;
                pGender.Size = 50;
                pGender.Value = employee.Gender;

                var pHDate = new SqlParameter();
                pHDate.ParameterName = "@hiring_date";
                pHDate.SqlDbType = SqlDbType.DateTime;
                pHDate.Value = employee.HiringDate;

                var pEmail = new SqlParameter();
                pEmail.ParameterName = "@email";
                pEmail.SqlDbType = SqlDbType.VarChar;
                pEmail.Size = 50;
                pEmail.Value = employee.Email;

                var pPNumber = new SqlParameter();
                pPNumber.ParameterName = "@phone_number";
                pPNumber.SqlDbType = SqlDbType.VarChar;
                pPNumber.Size = 50;
                pPNumber.Value = employee.PhoneNumber;

                var pDId = new SqlParameter();
                pDId.ParameterName = "@department_id";
                pDId.SqlDbType = SqlDbType.VarChar;
                pDId.Size = 50;
                pDId.Value = employee.DepartmentId;

                // Menambahkan parameter ke command
                command.Parameters.Add(pNik);
                command.Parameters.Add(pFName);
                command.Parameters.Add(pLName);
                command.Parameters.Add(pBDate);
                command.Parameters.Add(pGender);
                command.Parameters.Add(pHDate);
                command.Parameters.Add(pEmail);
                command.Parameters.Add(pPNumber);
                command.Parameters.Add(pDId);

                // Menjalankan command
                result = command.ExecuteNonQuery();
                transaction.Commit();

                return result;

            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

    }
}
