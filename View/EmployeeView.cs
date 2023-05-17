using ConsoleApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.View
{
    public class EmployeeView
    {
        public void DisplayEmployee()
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("         INSERT DATA TABLE EMPLOYEE         ");
            Console.WriteLine(" ");
            Console.WriteLine("==============================");

            var employees = new Employee();
            Console.Write("NIK: "); var nik = Console.ReadLine(); employees.NIK = nik;
            Console.Write("First Name: "); var fname = Console.ReadLine(); employees.FirstName = fname;
            Console.Write("Last Name: "); var lname = Console.ReadLine(); employees.LastName = lname;
            Console.Write("Birth Date: "); var bdate = DateTime.Parse(Console.ReadLine()); employees.BirthDate = bdate;
            Console.Write("Gender: "); var gender = Console.ReadLine(); employees.Gender = gender;
            Console.Write("Hiring Date: "); var hdate = DateTime.Parse(Console.ReadLine()); employees.HiringDate = hdate;
            Console.Write("Email: "); var email = Console.ReadLine(); employees.Email = email;
            Console.Write("Phone Number: "); var pnumber = Console.ReadLine(); employees.PhoneNumber = pnumber;
            Console.Write("Department Id: "); var did = Console.ReadLine(); employees.DepartmentId = did;

        }
    }
}
