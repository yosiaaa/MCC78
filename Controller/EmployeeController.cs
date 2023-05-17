using ConsoleApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controller
{
    public class EmployeeController
    {
        private Employee employee = new();

        public void GetAllDataLinq()
        {
            var emp = new Employee();
            var uni = new University();
            var edu = new Education();
            var pro = new Profiling();

            var empGetAll = emp.GetEmployees();
            var uniGetAll = uni.GetUniversities();
            var eduGetAll = edu.GetEducations();
            var proGetAll = pro.GetProfilings();

            var query = (from e in empGetAll
                         join p in proGetAll on e.Id equals p.EmployeeId
                         join ed in eduGetAll on p.EducationId equals ed.Id
                         join u in uniGetAll on ed.UniversityId equals u.Id
                         select new
                         {
                             e.NIK,
                             FullName = emp.FirstName + " " + emp.LastName,
                             e.BirthDate,
                             e.Gender,
                             e.HiringDate,
                             e.Email,
                             e.PhoneNumber,
                             ed.Major,
                             ed.Degree,
                             ed.GPA,
                             u.Name
                         });

            foreach (var item in query)
            {
                Console.WriteLine("NIK: " + item.NIK);
                Console.WriteLine("Full Name: " + item.FullName);
                Console.WriteLine("Birthdate: " + item.BirthDate);
                Console.WriteLine("Gender: " + item.Gender);
                Console.WriteLine("Hiring Date: " + item.HiringDate);
                Console.WriteLine("Email: " + item.Email);
                Console.WriteLine("Phone Number: " + item.PhoneNumber);
                Console.WriteLine("Major: " + item.Major);
                Console.WriteLine("Degree: " + item.Degree);
                Console.WriteLine("GPA: " + item.GPA);
                Console.WriteLine("University Name: " + item.Name);
                Console.WriteLine("\n===============================");
                
            }
            
        }
    }
}
