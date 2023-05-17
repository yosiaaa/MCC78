using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Model;

namespace ConsoleApp2.View
{
    public class EducationView
    {
        /*public void Output(Education educations)
        {
            Console.WriteLine("Id: " + educations.Id);
            Console.WriteLine("Major: " + educations.Major);
            Console.WriteLine("Degree: " + educations.Degree);
            Console.WriteLine("GPA: " + educations.GPA);
            Console.WriteLine("University Id:" + educations.UniversityId);
            Console.WriteLine("\n------------------------------------");   
        }

        public void Output(List<Education> education)
        {
            *//*var results = GetEducations();*//*
            foreach (var item in education)
            {
                Output(education);
            }
        }

        public void Output(string message)
        {
            Console.WriteLine(message);
        }

        public void Insert(Education education)
        {
            Console.WriteLine("Id" + education.Id);
            Console.WriteLine("Major: " + education.Major);
            Console.WriteLine("Degree: " + education.Degree);
            Console.WriteLine("GPA: " + education.GPA);
            Console.WriteLine("University Id: " + education.UniversityId);
        }

        public void Update(Education education)
        {
            Console.WriteLine("Id: " + education.Id);
            Console.WriteLine("Major: " + education.Major);
            Console.WriteLine("Degree: " + education.Degree);
            Console.WriteLine("GPA: " + education.GPA);
            Console.WriteLine("University Id: " + education.UniversityId);
        }

        public void Delete(Education education)
        {
            Console.WriteLine("Delete By Id: " + education.Id);
        }*/

        public void DisplayViewEducation()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("         CRUD TABLE EDUCATION        ");
            Console.WriteLine(" ");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. INSERT");
            Console.WriteLine("2. UPDATE");
            Console.WriteLine("3. DELETE");
        }

        public void GetDataEducation()
        {
            var education = new Education();
            Console.Write("Major: "); var major = Console.ReadLine(); education.Major = major;
            Console.Write("Degree: "); var degree = Console.ReadLine(); education.Degree = degree;
            Console.Write("GPA: "); var gpa = Console.ReadLine(); education.GPA = gpa;
            Console.Write("University Id: "); var uid = Convert.ToInt16(Console.ReadLine()); education.UniversityId = uid;
        }

        public void ViewInsertEducation()
        {
            var education = new Education();
            Console.WriteLine("=================================");
            Console.WriteLine("         INSERT EDUCATION        ");
            Console.WriteLine("=================================");
            Console.WriteLine("Major: " + education.Major);
            Console.WriteLine("Degree: " + education.Degree);
            Console.WriteLine("GPA: " + education.GPA);
            /*Console.WriteLine("University Id: " + education.UniversityId);*/
        }
        public void ViewUpdateEducation()
        {
            var education = new Education();
            education.UpdateEducations(education);
            Console.WriteLine("==================================");
            Console.WriteLine("         UPDATE EDUCATION         ");
            Console.WriteLine("==================================");
            Console.WriteLine("Id: "); var id = Convert.ToInt32(Console.ReadLine()); education.Id = id;
            Console.WriteLine("Major: "); var major = Console.ReadLine(); education.Major = major;
            Console.WriteLine("Degree: "); var degree = Console.ReadLine(); education.Degree = degree;
            Console.WriteLine("GPA: "); var gpa = Console.ReadLine(); education.GPA = gpa;
            /*Console.WriteLine("University Id: "); var uid = Convert.ToInt32(Console.ReadLine()); education.UniversityId = uid;*/
        }
        public void ViewDeleteEducation()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("         DELETE EDUCATION         ");
            Console.WriteLine("==================================");
            Console.WriteLine("Id: "); var id = Convert.ToInt32(Console.ReadLine()); var education = new Education(); education.Id = id;
        }

    }
}
