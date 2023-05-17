using ConsoleApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.View
{
    public class UniversityView
    {
        public void DisplayUniversity()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("         INSERT DATA UNIVERSITY      ");
            Console.WriteLine(" ");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. INSERT");
            Console.WriteLine("2. UPDATE");
            Console.WriteLine("3. DELETE");
        }

        public void GetDataUniversity()
        {
            var university = new University();
            Console.Write("University Name: "); 
            var uname = Console.ReadLine(); 
            university.Name = uname;
        }

    }
}
