using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2;
public class Program
{
    private static readonly string connectionString =
    "Data Source=INDOMIEGORENG;Database=db_booking_room;Integrated Security = True; Connect Timeout = 30; Encrypt=False;";

    public static void Main()
    {
        /*SqlConnection connection = new SqlConnection(connectionString);

        try {
            connection.Open();
            Console.WriteLine("Connection opened successfully.");
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        } finally {
            connection.Close();
            Console.WriteLine("Connection closed successfully.");
        }*/



        /* GET DATA TABLE UNIVERSITY*/
        /*var results = GetUniversities();
        foreach (var result in results)
        {
            Console.WriteLine("Id: " + result.Id);
            Console.WriteLine("Name: " + result.Name);
        }
        Console.WriteLine("\n===========Yosia===========");*/



        /* GET DATA TABLE EDUCATIONS */
        /*var results = GetEducations();
        foreach (var result in results)
        {
            Console.WriteLine("Id: " + result.Id);
            Console.WriteLine("Major: " + result.Major);
            Console.WriteLine("Degree: " + result.Degree);
            Console.WriteLine("GPA: " + result.GPA);
            Console.WriteLine("University Id:" + result.UniversityId);

            Console.WriteLine("\n------------------------------------");
        }
        Console.WriteLine("\n===========Yosia===========");*/

        /* GET DATA TABLE EMPLOYEE */
        /*var results = GetEmployees();
        foreach (var result in results)
        {
            Console.WriteLine("Id: " + result.Id);
            Console.WriteLine("NIK: " + result.NIK);
            Console.WriteLine("First Name: " + result.FirstName);
            Console.WriteLine("Last Name: " + result.LastName);
            Console.WriteLine("Birth Date:" + result.BirthDate);
            Console.WriteLine("Gender: " + result.Gender);
            Console.WriteLine("Hiring Date: " + result.HiringDate);
            Console.WriteLine("Email: " + result.Email);
            Console.WriteLine("Phone Number: " + result.PhoneNumber);
            Console.WriteLine("Department Id: " + result.DepartmentId);

            Console.WriteLine("\n------------------------------------");
        }
        Console.WriteLine("\n===========Yosia===========");*/



        /*var university = new University();
        university.Name = "Universitas Airlangga";

        // delete
        var result = DeleteUniversity(university);
        if (result > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete failed.");
        }*/


        // DELETE TABLE EDUCATIONS

        /*var education = new Educations();
        education.Major = "Teknik Informatika";

        // delete
        var result = DeleteEducations(education);
        if (result > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete failed.");
        }*/

        /*Console.WriteLine("Menambah Universitas Negri Solo");
        var university = new University();
        university.Name = "Universitas Negri Solo";
        university.Id = 6;*/

        // INSERT INTO TABLE EDUCATIONS
        /*var education = new Educations();
        education.Major = "Manajemen Bisnis";
        education.Degree = "S2";
        education.GPA = "3.8";
        education.UniversityId = 4;

        var result = InsertEducations(education);
        if(result > 0)
        {
            Console.WriteLine("Insert Success");
        } else
        {
            Console.WriteLine("Insert Failed");
        }*/

        // UPDATE TABLE UNIVERSITY

        /*var university = new University();
        university.Name = "Universitas Negri Solo";
        var result = UpdateUniversity(university);
        if (result > 0)
        {
            Console.WriteLine("Update success.");
        }
        else
        {
            Console.WriteLine("Update failed.");
        }*/


        // UPDATE TABLE EDUCATIONS

        /*var education = new Educations();
        education.Major = "Teknik Industri";
        education.Id = 5;

        var result = UpdateEducations(education);
        if (result > 0)
        {
            Console.WriteLine("Update Success");
        }
        else
        {
            Console.WriteLine("Update Failed");
        }*/

        /*Console.WriteLine("Get By ID = 5");
        var university = new University();
        university.Id = 5;
        GetByIdUniversity(university);

        Console.WriteLine("\n============= Yosia ============");*/


        // GET BY ID TABLE EDUCATIONS
        /*Console.WriteLine("Get By ID = 5");
        var education = new Educations();
        education.Id = 5;
        GetByIdEducations(education);

        Console.WriteLine("\n============= Yosia ============");*/

        /*bool ulang = true;
        while (ulang == true)
        {
            Menu();
            int pilihan;
            Console.Write("Menu yang dipilih: ");
            pilihan = Convert.ToInt16(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    var results = GetEmployees();
                    foreach (var result in results)
                    {
                        Console.WriteLine("Id: " + result.Id);
                        Console.WriteLine("NIK: " + result.NIK);
                        Console.WriteLine("First Name: " + result.FirstName);
                        Console.WriteLine("Last Name: " + result.LastName);
                        Console.WriteLine("Birth Date:" + result.BirthDate);
                        Console.WriteLine("Gender: " + result.Gender);
                        Console.WriteLine("Hiring Date: " + result.HiringDate);
                        Console.WriteLine("Email: " + result.Email);
                        Console.WriteLine("Phone Number: " + result.PhoneNumber);
                        Console.WriteLine("Department Id: " + result.DepartmentId);

                        Console.WriteLine("\n------------------------------------");
                    }
                    Console.WriteLine("\n===========Yosia===========");
                    break;
                case 2:
                    var resultss = GetProfilings();
                    foreach (var result in resultss)
                    {
                        Console.WriteLine("Employee Id: " + result.EmployeeId);
                        Console.WriteLine("Education Id: " + result.EducationId);

                        Console.WriteLine("\n------------------------------------");
                    }
                    Console.WriteLine("\n===========Yosia===========");
                    break;
                case 3:
                    var resultsss = GetEducations();
                    foreach (var result in resultsss)
                    {
                        Console.WriteLine("Id: " + result.Id);
                        Console.WriteLine("Major: " + result.Major);
                        Console.WriteLine("Degree: " + result.Degree);
                        Console.WriteLine("GPA: " + result.GPA);
                        Console.WriteLine("University Id:" + result.UniversityId);

                        Console.WriteLine("\n------------------------------------");
                    }
                    Console.WriteLine("\n===========Yosia===========");
                    break;
                case 4:
                    //GET DATA TABLE UNIVERSITY
                    var resultssss = GetUniversities();
                    foreach (var result in resultssss)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Id: " + result.Id);
                        Console.WriteLine("Name: " + result.Name);
                    }
                    //Console.WriteLine("\n===========Yosia===========");
                    break;
                case 5:
                    ulang = false;
                    Console.Clear();
                    Console.WriteLine("Terima Kasih");
                    break;
                default:
                    Console.WriteLine("Anda salah input, silahkan periksa kembali.");
                    Thread.Sleep(2000); // lalu akan kembali pada tampilan halaman utama..
                    break;
            }
        }*/

            /*var education = new Educations();
            education.Major = "Manajemen Bisnis";
            education.Degree = "S2";
            education.GPA = "3.8";
            education.UniversityId = 4;

            var results = InsertEducations(education);
            if (results > 0)
            {
                Console.WriteLine("Insert Success");
            }
            else
            {
                Console.WriteLine("Insert Failed");
            }*/

            var employees = new Employees();
            Console.Write("NIK: "); var nik = Console.ReadLine(); employees.NIK = nik;
            Console.Write("First Name: "); var fname = Console.ReadLine(); employees.FirstName = fname;
            Console.Write("Last Name: "); var lname = Console.ReadLine(); employees.LastName = lname;
            Console.Write("Birth Date: "); var bdate = DateTime.Parse(Console.ReadLine()); employees.BirthDate = bdate;
            Console.Write("Gender: "); var gender = Console.ReadLine(); employees.Gender = gender;
            Console.Write("Hiring Date: "); var hdate = DateTime.Parse(Console.ReadLine()); employees.HiringDate = hdate;
            Console.Write("Email: "); var email = Console.ReadLine(); employees.Email = email;
            Console.Write("Phone Number: "); var pnumber = Console.ReadLine(); employees.PhoneNumber = pnumber;
            Console.Write("Department Id: "); var did = Console.ReadLine(); employees.DepartmentId = did;
            Employees.InsertEmployees(employees);

            var university = new University();
            Console.Write("Name University: "); var name = Console.ReadLine(); university.Name = name;
            University.InsertUniversity(university);

            var educations = new Educations();
            Console.Write("Major: "); var major = Console.ReadLine(); educations.Major = major;
            Console.Write("Degree: "); var degree = Console.ReadLine(); educations.Degree = degree;
            Console.Write("GPA: "); var gpa = Console.ReadLine(); educations.GPA = gpa;
            educations.UniversityId = GetIdUniv();
            /*Console.WriteLine(educations.UniversityId);*/
            Educations.InsertEducations(educations);

            var profilings = new Profilings();
            /*Console.WriteLine(employees.NIK);*/
            profilings.EmployeeId = GetGuidEmployee(employees.NIK);
            profilings.EducationId = GetIdEducation();
            Console.WriteLine("Employee Id: " + profilings.EmployeeId);
            Console.WriteLine("Education Id: " + profilings.EducationId);
            Profilings.InsertProfilings(profilings);
        }
    
    public static int GetIdEducation()
    {
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        SqlCommand command = new SqlCommand("SELECT TOP 1 id FROM tb_m_educations ORDER BY id DESC", connection);
        int lastInserted = Convert.ToInt32(command.ExecuteScalar());
        connection.Close();

        return lastInserted;
    }

    public static int GetIdUniv()
    {
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        SqlCommand command = new SqlCommand("SELECT TOP 1 id FROM tb_m_universities ORDER BY id DESC", connection);
        int lastInserted = Convert.ToInt32(command.ExecuteScalar());
        connection.Close();

        return lastInserted;
    }

    public static string GetGuidEmployee(string NIK)
    {
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        SqlCommand command = new SqlCommand("SELECT TOP 1 id FROM tb_m_employees WHERE NIK = (@nik)", connection);

        // Membuat parameter
        var pNik = new SqlParameter();
        pNik.ParameterName = "@nik";
        pNik.SqlDbType = SqlDbType.Char;
        pNik.Size = 6;
        pNik.Value = NIK;

        command.Parameters.Add(pNik);

        string lastInserted = Convert.ToString(command.ExecuteScalar());

        connection.Close();

        return lastInserted;

            
        

    }

    /* CRUD TABLE UNIVERSITY */

    // METHOD GET UNIVERISTY
    public static List<University> GetUniversities()
    {
        var universities = new List<University>();
        using SqlConnection connection = new SqlConnection(connectionString);
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

    // METHOD GETBYID : University

    public static int GetByIdUniversity(University university)
    {
        int result = 0;
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            // Command melakukan delete
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM tb_m_universities WHERE id = (@id)";
            command.Transaction = transaction;

            // Membuat parameter
            var pName = new SqlParameter();
            pName.ParameterName = "@id";
            pName.Value = university.Id;

            // Menambahkan parameter ke command
            command.Parameters.Add(pName);

            // Menjalankan command
            result = command.ExecuteNonQuery();
            transaction.Commit();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("Id: " + reader["id"]);
                    Console.WriteLine("Name: " + reader["name"]);
                }
            }
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


    // INSERT : Universities
    public static int InsertUniversity(University university)
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
            transaction.Rollback();
        }
        finally
        {
            connection.Close();
        }

        return result;
    }

    // INSERT EMPLOYEE

    public static int InsertEmployees(Employees employee)
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
            pBDate.Size = 50;
            pBDate.Value = employee.LastName;

            var pGender = new SqlParameter();
            pGender.ParameterName = "@gender";
            pGender.SqlDbType = SqlDbType.VarChar;
            pGender.Size = 50;
            pGender.Value = employee.Gender;

            var pHDate = new SqlParameter();
            pHDate.ParameterName = "@hiring_date";
            pHDate.SqlDbType = SqlDbType.DateTime;
            pHDate.Size = 50;
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

    // UPDATE : Universities(obj)
    public static int UpdateUniversity(University university)
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



    // DELETE : Universities(5)
    public static int DeleteUniversity(University university)
    {
        int result = 0;
        using var connection = new SqlConnection(connectionString);
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


    /* CRUD TABLE EDUCATIONS*/

    /* GET DATA EDUCATIONS */
    public static List<Educations> GetEducations()
    {
        var educations = new List<Educations>();
        using SqlConnection connection = new SqlConnection(connectionString);
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
                    var education = new Educations();

                    education.Id = reader.GetInt32(0);
                    education.Major = reader.GetString(1);
                    education.Degree = reader.GetString(2);
                    education.GPA = reader.GetString(3);
                    education.UniversityId = reader.GetInt32(4);

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
        return new List<Educations>();
    }


    /* GET TABLE EMPLOYEE */
    public static List<Employees> GetEmployees()
    {
        var employees = new List<Employees>();
        using SqlConnection connection = new SqlConnection(connectionString);
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
                    var employee = new Employees();

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
        return new List<Employees>();
    }

    // GET TABLE PROFILINGS

    public static List<Profilings> GetProfilings()
    {
        var profilings = new List<Profilings>();
        using SqlConnection connection = new SqlConnection(connectionString);
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
                    var profiling = new Profilings();

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
        return new List<Profilings>();
    }


    /* GET BY ID TABLE EDUCATIONS */
    public static int GetByIdEducations(Educations education)
    {
        int result = 0;
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            // Command melakukan delete
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM tb_m_educations WHERE id = (@id)";
            command.Transaction = transaction;

            // Membuat parameter
            var pName = new SqlParameter();
            pName.ParameterName = "@id";
            pName.Value = education.Id;

            // Menambahkan parameter ke command
            command.Parameters.Add(pName);

            // Menjalankan command
            result = command.ExecuteNonQuery();
            transaction.Commit();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("Id: " + reader["id"]);
                    Console.WriteLine("Major: " + reader["major"]);
                    Console.WriteLine("Degree: " + reader["degree"]);
                    Console.WriteLine("GPA: " + reader["gpa"]);
                    Console.WriteLine("University Id: " + reader["university_id"]);
                }
            }
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


    /* INSERT TABLE EDUCATIONS */

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

    public static int UpdateEducations(Educations education)
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
            command.CommandText = "UPDATE tb_m_educations SET Major = (@major) WHERE Id = (@id)";
            command.Transaction = transaction;

            // Membuat parameter Major
            var pName = new SqlParameter();
            pName.ParameterName = "@major";
            pName.SqlDbType = SqlDbType.VarChar;
            pName.Size = 50;
            pName.Value = education.Major;

            /*var pDegree = new SqlParameter();
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
            pUId.Value = education.UniversityId;*/

            var pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.SqlDbType = SqlDbType.Int;
            pId.Value = education.Id;

            // Menambahkan parameter ke command
            command.Parameters.Add(pName);
            /*command.Parameters.Add(pDegree);
            command.Parameters.Add(pGPA);
            command.Parameters.Add(pUId);*/
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

    public static int DeleteEducations(Educations education)
    {
        int result = 0;
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            // Command melakukan delete
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM tb_m_educations WHERE Major = (@major)";
            command.Transaction = transaction;

            // Membuat parameter
            var pName = new SqlParameter();
            pName.ParameterName = "@major";
            pName.Value = education.Major;

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

    static void Menu()
    {
        Console.WriteLine("================================");
        Console.WriteLine(" MENU MENAMPILKAN DATA TABLE DATABASE");
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("1. SHOW DATA TABLE EMPLOYEE");
        Console.WriteLine("2. SHOW DATA TABLE PROFILING");
        Console.WriteLine("3. SHOW DATA TABLE EDUCATION");
        Console.WriteLine("4. DATA TABLE UNIVERSITY");
        Console.WriteLine("5. Exit");
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("================================");
    }

    static void MenuInsertAll()
    {
        Console.WriteLine("================================");
        Console.WriteLine("        MENU INSERT TABLE       ");
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("1. INSERT DATA TABLE EMPLOYEE");
        Console.WriteLine("2. INSERT DATA TABLE PROFILING");
        Console.WriteLine("3. INSERT DATA TABLE EDUCATION");
        Console.WriteLine("4. INSERT DATA TABLE UNIVERSITY");
        Console.WriteLine("5. EXIT");
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("================================");
    }

}