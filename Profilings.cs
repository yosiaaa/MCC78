using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Profilings
    {
        public string EmployeeId { get; set; }
        public int EducationId { get; set; }

        private static readonly string connectionString =
        "Data Source=INDOMIEGORENG;Database=db_booking_room;Integrated Security = True; Connect Timeout = 30; Encrypt=False;";


        public static int GetGuidEmployee(string NIK)
        {
            int result = 0;
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT TOP 1 id FROM tb_m_employees WHERE nik = (@nik)";
                command.Transaction = transaction;

                // Membuat parameter
                var pNik = new SqlParameter();
                pNik.ParameterName = "@nik";
                pNik.Value = NIK;

                // Menambahkan parameter ke command
                command.Parameters.Add(pNik);

                // Menjalankan command
                result = command.ExecuteNonQuery();
                transaction.Commit();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("Id: " + reader["id"]);
                    }
                }
                return result;
            } catch (Exception ex) {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public static int InsertProfilings(Profilings profilings) {
            int result = 0;
            using var connection = new SqlConnection(connectionString);
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
    }
}
