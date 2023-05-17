using ConsoleApp2.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    public class Profiling
    {
        public string EmployeeId { get; set; }
        public int EducationId { get; set; }

        public List<Profiling> GetProfilings()
        {
            var profilings = new List<Profiling>();
            using SqlConnection connection = MyConnection.Get();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tb_tr_profilings";

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var profiling = new Profiling();

                        profiling.EmployeeId = reader.GetGuid(0).ToString();
                        profiling.EducationId = reader.GetInt32(1);

                        profilings.Add(profiling);
                    }

                    return profilings;
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
            return new List<Profiling>();
        }

        public static string GetGuidEmployee(string NIK)
        {
            using var connection = MyConnection.Get();
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT id FROM tb_m_employees WHERE nik = (@nik)", connection);

            var pNik = new SqlParameter();
            pNik.ParameterName = NIK;
            pNik.Value = NIK;
            
            command.Parameters.Add(pNik);

            string lastEmpId = Convert.ToString(command.ExecuteScalar());
            connection.Close();

            return lastEmpId;
        }

        public static int InsertProfilings(Profiling profilings)
        {
            int result = 0;
            using var connection = MyConnection.Get();
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO tb_tr_profilings(employee_id, education_id) VALUES (@employee_id, @education_id)";
                command.Transaction = transaction;

                var pEmId = new SqlParameter();
                pEmId.ParameterName = "@employee_id";
                pEmId.SqlDbType = SqlDbType.VarChar;
                pEmId.Value = profilings.EmployeeId;

                // Membuat parameter
                var pEId = new SqlParameter();
                pEId.ParameterName = "@education_id";
                pEId.SqlDbType = SqlDbType.Int;
                pEId.Size = 50;
                pEId.Value = profilings.EducationId;

                command.Parameters.Add(pEId);
                command.Parameters.Add(pEmId);
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

        public int UpdateProfilings(Profiling profilings)
        {
            int result = 0;
            using var connection = MyConnection.Get();
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE tb_tr_profilings SET employee_id = @employee_id, education_id = @education_id WHERE employee_id = @employee_id";
                command.Transaction = transaction;

                var pEmId = new SqlParameter();
                pEmId.ParameterName = "@employee_id";
                pEmId.SqlDbType = SqlDbType.VarChar;
                pEmId.Value = profilings.EmployeeId;

                // Membuat parameter
                var pEId = new SqlParameter();
                pEId.ParameterName = "@education_id";
                pEId.SqlDbType = SqlDbType.Int;
                pEId.Size = 50;
                pEId.Value = profilings.EducationId;


                command.Parameters.Add(pEId);
                command.Parameters.Add(pEmId);
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

        public int DeleteProfilings(Profiling profilings)
        {
            int result = 0;
            using var connection = MyConnection.Get();
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE tb_tr_profilings WHERE employee_id = @employee_id";
                command.Transaction = transaction;

                var pEmId = new SqlParameter();
                pEmId.ParameterName = "@employee_id";
                pEmId.SqlDbType = SqlDbType.VarChar;
                pEmId.Value = profilings.EmployeeId;

                // Membuat parameter
                var pEId = new SqlParameter();
                pEId.ParameterName = "@education_id";
                pEId.SqlDbType = SqlDbType.Int;
                pEId.Size = 50;
                pEId.Value = profilings.EducationId;

                command.Parameters.Add(pEId);
                command.Parameters.Add(pEmId);
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
