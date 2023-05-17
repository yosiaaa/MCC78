using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Model;

namespace ConsoleApp2.View
{
    public class ProfilingView
    {
        public void Output(Profiling profiling)
        {
            Console.WriteLine("Employee Id: " + profiling.EmployeeId);
            Console.WriteLine("Education Id: " + profiling.EducationId);
        }

        public void Output(List<Profiling> profiling)
        {
            foreach (var item in profiling)
            {
                Output(profiling);
            }
        }
        
        public void Output(string message)
        {
            Console.WriteLine(message);
        }

        public void Insert(Profiling profiling)
        {
            Console.WriteLine("Employee Id: " + profiling.EmployeeId);
            Console.WriteLine("Education Id: " + profiling.EducationId);
        }

        public void Update(Profiling profiling)
        {
            Console.WriteLine("Employee Id: " + profiling.EmployeeId);
            Console.WriteLine("Education Id: " + profiling.EducationId);
        }

        public void Delete(Profiling profiling)
        {
            Console.WriteLine("Delete By Id: " + profiling.EmployeeId);
        }
    }
}
