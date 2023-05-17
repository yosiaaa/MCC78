using System.Linq;
using ConsoleApp2.Controller;
using ConsoleApp2.Model;


namespace ConsoleApp2.View
{
    public class MenuView
    {
        public void MenuDisplay()
        {
            Console.WriteLine("================================");
            Console.WriteLine("        MENU INSERT TABLE       ");
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("1. INSERT DATA ");
            Console.WriteLine("2. CRUD UNIVERSITY");
            Console.WriteLine("3. CRUD EDUCATION");
            Console.WriteLine("4. LINQ");
            Console.WriteLine("5. EXIT");
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Pilih Angka Pada Menu: ");

            int pilihan;
            pilihan = Convert.ToInt32(Console.ReadLine());
            bool ulang = true;
            
            while(ulang == true)
            {
                switch(pilihan)
                {
                    case 1:
                        var employee = new Employee();
                        EmployeeView employeeView = new EmployeeView();
                        employeeView.DisplayEmployee();
                        employee.InsertEmployees(employee);

                        var university = new University();
                        UniversityView universityView = new UniversityView();
                        universityView.GetDataUniversity();
                        university.InsertUniversity(university);

                        var education = new Education();
                        EducationView educationView = new EducationView();
                        educationView.GetDataEducation();
                        education.UniversityId = education.GetUnivEduId(1);
                        education.InsertEducations(education);

                        var profiling = new Profiling();
                        var educationGetId = new Education();
                        profiling.EmployeeId = Profiling.GetGuidEmployee(employee.NIK);
                        profiling.EducationId = educationGetId.GetUnivEduId(2);
                        ProfilingController profilingController = new();
                        profilingController.Get();
                        Console.WriteLine("\n===============================================");
                        break;
                    case 2:
                        UniversityView universityViewNew = new UniversityView();
                        universityViewNew.DisplayUniversity();
                        Console.WriteLine("Pilih Menu: ");

                        int pilihanCrudTbUniversity;
                        pilihanCrudTbUniversity = Convert.ToInt32(Console.ReadLine());
                        bool ulangCrudTbUniversity = true;
                        UniversityController controller = new();

                        while(ulangCrudTbUniversity == true)
                        {
                            switch (pilihanCrudTbUniversity)
                            {
                                case 1:
                                    controller.Insert();
                                    break;
                                case 2:
                                    controller.Update();
                                    break;
                                case 3:
                                    controller.Delete();
                                    break;
                                case 4:
                                    ulangCrudTbUniversity = false;
                                    Console.Clear();
                                    Console.WriteLine("Thank You!");
                                    break;
                                default:
                                    Console.WriteLine("The data entered is incorrect, please check again.");
                                    Thread.Sleep(2000);
                                    break;
                            }
                            break;
                        }
                        break;
                    case 3:
                        EducationView educationViewNew = new EducationView();
                        educationViewNew.DisplayViewEducation();
                        Console.WriteLine("Pilih Menu: ");

                        int pilihanCrudTbEducation;
                        pilihanCrudTbEducation = Convert.ToInt32(Console.ReadLine());
                        bool ulangCrudTbEducation = true;

                        EducationController educationController = new();
                        EducationView educationView1 = new();

                        while(ulangCrudTbEducation == true)
                        {
                            switch(pilihanCrudTbEducation)
                            {
                                case 1:
                                    educationView1.ViewInsertEducation();
                                    educationController.Insert();
                                    break;
                                case 2:
                                    educationView1.ViewUpdateEducation();
                                    educationController.Update();
                                    break;
                                case 3:
                                    educationView1.ViewDeleteEducation();
                                    educationController.Delete();
                                    break;
                                case 4:
                                    ulangCrudTbEducation = false;
                                    Console.Clear();
                                    Console.WriteLine("Thank You!");
                                    break;
                                default:
                                    Console.WriteLine("The data entered is incorrect, please check again.");
                                    Thread.Sleep(2000);
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("=======================================");
                        Console.WriteLine("                 LINQ                  ");
                        Console.WriteLine("=======================================");
                        EmployeeController employeeController = new();
                        employeeController.GetAllDataLinq();
                        break;
                    case 5:
                        ulang = false;
                        Console.Clear();
                        Console.WriteLine("Terima Kasih");
                        break;
                    default:
                        Console.WriteLine("The data entered is incorrect, please check again.");
                        Thread.Sleep(2000);
                        break;
                }
            }

        }
    }
}
