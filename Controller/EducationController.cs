using ConsoleApp2.Model;
using ConsoleApp2.View;

namespace ConsoleApp2.Controller
{
    public class EducationController
    {

        public void Insert()
        {
            var education = new Education();
            var results = education.InsertEducations(education);
            if(results > 0)
            {
                Console.WriteLine("Insert Success");
            } else
            {
                Console.WriteLine("Insert Failed");
            }
        }

        public void Update()
        {
            var education = new Education();
            var results = education.UpdateEducations(education);
            if(results == 0)
            {
                Console.WriteLine("Update Success");
            } else
            {
                Console.WriteLine("Update Failed");
            }
        }

        public void Delete()
        {
            var education = new Education();
            var results = education.DeleteEducations(education);
            // delete
            if (results > 0)
            {
                Console.WriteLine("Delete Success");
            }
            else
            {
                Console.WriteLine("Delete failed.");
            }
            
        }
    }
}
