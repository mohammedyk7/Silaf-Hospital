using System;

namespace Silaf_Hospital.Models
{
    public class SuperAdmin : User
    {
        public SuperAdmin() { }

        public SuperAdmin(string fullName, string email, string password)
            : base(fullName, email, password, "SuperAdmin") { }

        public Admin CreateAdmin()
        {
            return Admin.CreateFromInput();
        }

        public void DoctorMenu()
        {
            Doctor.displayDoctorInterFacse(); // must exist in Doctor.cs
        }


        public void Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("👑 Super Admin Panel");
                Console.WriteLine("1. Manage Doctors");
                Console.WriteLine("2. Add Admin");
                Console.WriteLine("3. Add Branch");
                Console.WriteLine("4. Manage Departments");
                Console.WriteLine("5. Assign Department to Branch");
                Console.WriteLine("6. Assign doctors to clinics  ");
                Console.WriteLine("7. View Doctor-Clinic Assignments");
                Console.WriteLine("8. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Doctor.displayDoctorInterFacse();
                        break;
                    case "2":
                        Admin admin = Admin.CreateFromInput();
                        Console.WriteLine("✅ Admin created.");
                        break;
                    case "3":
                        Branch branch = Branch.CreateBranchFromInput();
                        branch.Display();
                        break;
                    case "4":
                        Department deptMenu = new Department();
                        deptMenu.RunDepartmentMenu();
                        break;
                    case "5":
                        BranchDepartment.AssignDepartmentToBranch();
                        break;

                    case "6":
                        Clinic.AssignDoctorToClinic();
                        break;

                    case "7":
                        Clinic.AssignDoctorToClinic();
                        break;

                
                    case "8":
                        return;
                    default:
                        Console.WriteLine("❌ Invalid option.");
                        break;
                }

                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }


    }
}
