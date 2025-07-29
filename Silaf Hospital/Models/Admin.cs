using System;
using System.Collections.Generic;

namespace Silaf_Hospital.Models
{
    public class Admin : User
    {
        public int BranchId { get; set; }
        public Branch? Branch { get; set; }

        // Parameterless constructor for EF or manual creation
        public Admin() { }

        // Constructor with required fields
        public Admin(string fullName, string email, string password, int branchId)
            : base(fullName, email, password, "Admin")
        {
            BranchId = branchId;
        }

        // Static menu for Admin management
        public static void AdminMenu(List<Admin> admins)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("🏢 Admin Management Menu:");
                Console.WriteLine("1. Add Admin");
                Console.WriteLine("2. View All Admins");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n📝 Enter Admin Info:");

                        Console.Write("Full Name: ");
                        string fullName = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        Console.Write("Password: ");
                        string password = Console.ReadLine();

                        Console.Write("Branch ID: ");
                        int branchId;
                        while (!int.TryParse(Console.ReadLine(), out branchId))
                        {
                            Console.Write("❌ Invalid number. Enter Branch ID again: ");
                        }

                        Admin newAdmin = new Admin(fullName, email, password, branchId);
                        admins.Add(newAdmin);

                        Console.WriteLine("✅ Admin Added!");
                        break;

                    case "2":
                        Console.WriteLine("\n📋 All Admins:");
                        if (admins.Count == 0)
                        {
                            Console.WriteLine("No admins yet.");
                        }
                        else
                        {
                            foreach (var admin in admins)
                            {
                                Console.WriteLine($"- {admin.FullName} ({admin.Email}) | Branch ID: {admin.BranchId}");
                            }
                        }
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("❌ Invalid option. Press Enter to try again...");
                        Console.ReadLine();
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
            }
        }
        public static Admin CreateFromInput()
        {
            Console.WriteLine("\n📝 Enter Admin Info:");

            Console.Write("Full Name: ");
            string fullName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Branch ID: ");
            int branchId;
            while (!int.TryParse(Console.ReadLine(), out branchId))
            {
                Console.Write("❌ Invalid input. Enter a valid Branch ID: ");
            }

            return new Admin(fullName, email, password, branchId);
        }

    }
}
