using System.Data.SqlClient;
using System.Data;
using ConsoleApp2.Context;

namespace ConsoleApp2.Model
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public List<University> GetUniversities()
        {
            var universities = new List<University>();
            using SqlConnection connection = MyConnection.Get();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tb_m_universities";

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var university = new University();
                        university.Id = reader.GetInt32(0);
                        university.Name = reader.GetString(1);

                        universities.Add(university);
                    }

                    return universities;
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
            return new List<University>();
        }

        public int GetByIdUniversity(University university)
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
                command.CommandText = "SELECT * FROM tb_m_universities WHERE id = @id";
                command.Transaction = transaction;

                // Membuat parameter
                var pId = new SqlParameter();
                pId.ParameterName = "@id";
                pId.Value = university.Id;

                // Menambahkan parameter ke command
                command.Parameters.Add(pId);

                // Menjalankan command
                /*result = command.ExecuteNonQuery();
                transaction.Commit();*/

                using SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("===========================================");
                        Console.WriteLine("                   CRUD                    ");
                        Console.WriteLine("       GET TABLE UNIVERSITY BY ID          ");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("Id     :" + reader.GetInt32(0));
                        Console.WriteLine("Name   :" + reader.GetString(1));
                        Console.WriteLine(" ");
                        Console.WriteLine("===========================================");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }


        public int InsertUniversity(University university)
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
                command.CommandText = "INSERT INTO tb_m_universities(name) VALUES (@name)";
                command.Transaction = transaction;

                // Membuat parameter
                var pName = new SqlParameter();
                pName.ParameterName = "@name";
                pName.SqlDbType = SqlDbType.VarChar;
                pName.Size = 50;
                pName.Value = university.Name;

                // Menambahkan parameter ke command
                command.Parameters.Add(pName);

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

        public int UpdateUniversity(University university)
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
                command.CommandText = "UPDATE tb_m_universities SET Name = (@name) WHERE Id = (@id)";
                command.Transaction = transaction;

                // Membuat parameter
                var pName = new SqlParameter();
                pName.ParameterName = "@name";
                pName.SqlDbType = SqlDbType.VarChar;
                pName.Size = 50;
                pName.Value = university.Name;

                var pId = new SqlParameter();
                pId.ParameterName = "@id";
                pId.SqlDbType = SqlDbType.Int;
                pId.Value = university.Id;

                // Menambahkan parameter ke command
                command.Parameters.Add(pName);
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

        public int DeleteUniversity(University university)
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
                command.CommandText = "DELETE FROM tb_m_universities WHERE Name = (@name)";
                command.Transaction = transaction;

                // Membuat parameter
                var pName = new SqlParameter();
                pName.ParameterName = "@name";
                pName.Value = university.Name;

                // Menambahkan parameter ke command
                command.Parameters.Add(pName);

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
