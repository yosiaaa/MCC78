using ConsoleApp2.Model;
using ConsoleApp2.View;

namespace ConsoleApp2.Controller
{
    public class UniversityController
    {

        public void Insert()
        {
            var university = new University();
            Console.WriteLine("=====================================");
            Console.WriteLine("         INSERT TABLE UNIVERSITY     ");
            Console.WriteLine("=====================================");
            Console.WriteLine("UNIVERSITY NAME: ");
            var uName = Console.ReadLine();
            university.Name = uName;

            var results = university.InsertUniversity(university);
            if (results > 0)
            {
                Console.WriteLine("Insert Success");
            }
            else
            {
                Console.WriteLine("Insert Failed!");
            }
        }

        public void Update()
        {
            var university = new University();
            university.UpdateUniversity(university);
            Console.WriteLine("=====================================");
            Console.WriteLine("         UPDATE TABLE UNIVERSITY     ");
            Console.WriteLine("=====================================");
            Console.Write("University Id   : ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("University Name: ");
            var uName = Console.ReadLine();

            university.Id = id;
            university.Name = uName;

            var results = university.UpdateUniversity(university);
            if (results > 0)
            {
                Console.WriteLine("Update Success");
            }
            else
            {
                Console.WriteLine("Update Failed!");
            }
        }

        public void Delete()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("         DELETE TABLE UNIVERSITY      ");
            Console.WriteLine("======================================");
            Console.WriteLine("University Id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var university = new University();
            university.Id = id;

            var results = university.DeleteUniversity(university);
            if(results > 0)
            {
                Console.WriteLine("Delete Success");
            } else
            {
                Console.WriteLine("Delete Failed!");
            }
        }
    }
}
