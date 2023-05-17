using System.Data.SqlClient;
using System.Data;
using ConsoleApp2.Context;

namespace ConsoleApp2.Model
{
    public class Education
    {
        public int Id { get; set; }
        public string Major { get; set; }
        public string Degree { get; set; }
        public string GPA { get; set; }
        public int UniversityId { get; set; }

        public List<Education> GetEducations()
        {
            var educations = new List<Education>();
            using SqlConnection connection = MyConnection.Get();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tb_m_educations";

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var education = new Education();

                        education.Id = reader.GetInt32(0);
                        education.Major = reader.GetString(1);
                        education.Degree = reader.GetString(2);
                        education.GPA = reader.GetString(3);
                        education.UniversityId = reader.GetInt32(0);

                        educations.Add(education);
                    }

                    return educations;
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
            return new List<Education>();
        }

        public int GetByIdEducation(Education education)
        {
            int result = 0;
            using var connection = MyConnection.Get();
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tb_m_educations WHERE id = (@id)";
                command.Transaction = transaction;

                // Membuat parameter
                var pId = new SqlParameter();
                pId.ParameterName = "@id";
                pId.Value = education.Id;

                // Menambahkan parameter ke command
                command.Parameters.Add(pId);

                // Menjalankan command
                result = command.ExecuteNonQuery();
                transaction.Commit();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("Id: " + reader["id"]);
                        /*Console.WriteLine("Name: " + reader["name"]);*/
                    }
                }
                return result;
            } catch (Exception ex)
            {
                transaction.Rollback();
            } finally
            {
                connection.Close();
            }

            return result;
        }

        public int GetUnivEduId(int pilihan)
        {
            using var connection = MyConnection.Get();
            connection.Open();

            if(pilihan == 1)
            {
                SqlCommand command = new SqlCommand("SELECT TOP 1 id FROM tb_m_universities ORDER BY id DESC", connection);

                int id = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                return id;
            } else
            {
                SqlCommand command = new SqlCommand("SELECT TOP 1 id FROM tb_m_educations ORDER BY id DESC", connection);

                int id = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                return id;
            }
        }

        public int InsertEducations(Education education)
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
                command.CommandText = "INSERT INTO tb_m_educations(major, degree, gpa, university_id) VALUES (@major, @degree, @gpa, @university_id)";
                command.Transaction = transaction;

                // Membuat parameter major
                var pMajor = new SqlParameter();
                pMajor.ParameterName = "@major";
                pMajor.SqlDbType = SqlDbType.VarChar;
                pMajor.Size = 50;
                pMajor.Value = education.Major;

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
                pGPA.Size = 5;
                pGPA.Value = education.GPA;

                // Membuat Parameter University Id
                var pUId = new SqlParameter();
                pUId.ParameterName = "@university_id";
                pUId.SqlDbType = SqlDbType.Int;
                pUId.Size = 5;
                pUId.Value = education.UniversityId;

                // Menambahkan parameter ke command
                command.Parameters.Add(pMajor);
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
                Console.WriteLine(e.Message);
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public int UpdateEducations(Education education)
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
                command.CommandText = "UPDATE tb_m_educations SET major = @major, degree = @degree, gpa = @gpa, university_id = @university_id WHERE Id = @id";
                command.Transaction = transaction;

                // Membuat parameter Major
                var pName = new SqlParameter();
                pName.ParameterName = "@major";
                pName.SqlDbType = SqlDbType.VarChar;
                pName.Size = 50;
                pName.Value = education.Major;

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

                var pId = new SqlParameter();
                pId.ParameterName = "@id";
                pId.SqlDbType = SqlDbType.Int;
                pId.Value = education.Id;

                // Menambahkan parameter ke command
                command.Parameters.Add(pName);
                command.Parameters.Add(pDegree);
                command.Parameters.Add(pGPA);
                command.Parameters.Add(pUId);
                command.Parameters.Add(pId);

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

        public int DeleteEducations(Education education)
        {
            int result = 0;
            using var connection = MyConnection.Get();
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // Command melakukan delete
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM tb_m_educations WHERE id = @id";
                command.Transaction = transaction;

                // Membuat parameter
                var pId = new SqlParameter();
                pId.ParameterName = "@id";
                pId.Value = education.Id;

                // Menambahkan parameter ke command
                command.Parameters.Add(pId);

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
