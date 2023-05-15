using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Educations
    {
        public int Id { get; set; }
        public string Major { get; set; }
        public string Degree { get; set; }
        public string GPA { get; set; }
        public int UniversityId { get; set; }

        private static readonly string connectionString =
        "Data Source=INDOMIEGORENG;Database=db_booking_room;Integrated Security = True; Connect Timeout = 30; Encrypt=False;";

        public static int InsertEducations(Educations education)
        {
            int result = 0;
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // Command melakukan insert
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO tb_m_educations(major, degree, gpa, university_id) VALUES (@major, @degree, @gpa, @university_id)";
                command.Transaction = transaction;

                // Membuat parameter major
                var pName = new SqlParameter();
                pName.ParameterName = "@major";
                pName.SqlDbType = SqlDbType.VarChar;
                pName.Size = 50;
                pName.Value = education.Major;

                // Membuat parameter Degree
                var pDegree = new SqlParameter();
                pDegree.ParameterName = "@degree";
                pDegree.SqlDbType = SqlDbType.VarChar;
                pDegree.Size = 50;
                pDegree.Value = education.Degree;

                // Membuat parameter GPA
                var pGPA = new SqlParameter();
                pGPA.ParameterName = "@gpa";
                pGPA.SqlDbType = SqlDbType.VarChar;
                pGPA.Size = 50;
                pGPA.Value = education.GPA;

                // Membuat Parameter University Id
                var pUId = new SqlParameter();
                pUId.ParameterName = "@university_id";
                pUId.SqlDbType = SqlDbType.Int;
                pUId.Size = 50;
                pUId.Value = education.UniversityId;

                // Menambahkan parameter ke command
                command.Parameters.Add(pName);
                command.Parameters.Add(pDegree);
                command.Parameters.Add(pGPA);
                command.Parameters.Add(pUId);

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
