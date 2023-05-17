using ConsoleApp2.Model;
using ConsoleApp2.View;

namespace ConsoleApp2.Controller
{
    public class ProfilingController
    {
        public void Get()
        {
            var profiling = new Profiling();
            var result = Profiling.InsertProfilings(profiling);

            if(result > 0)
            {
                Console.WriteLine("Insert Success");
            } else
            {
                Console.WriteLine("Insert Failed");
            }
        }
    }
}
