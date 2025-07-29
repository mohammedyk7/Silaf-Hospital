using System;
using System.Collections.Generic;
using System.Drawing;

namespace Silaf_Hospital.Models
{
    public class Department
    {
        public string DepartmentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FloorNumber { get; set; }
        public string HeadOfDepartment { get; set; }
        public string ExtensionNumber { get; set; }



        public List<Department> departments = new List<Department>();

        public void AddDepartment()
        {
            Console.Write("Enter Department ID: ");
            string id = Console.ReadLine();

            if (departments.Exists(d => d.DepartmentID == id))
            {
                Console.WriteLine(" Department ID already exists.");
                return;
            }

            Console.Write("Enter Department Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Description: ");
            string desc = Console.ReadLine();

            int floor;
            Console.Write("Enter Floor Number: ");
            while (!int.TryParse(Console.ReadLine(), out floor))
            {
                Console.Write("Invalid floor number. Try again: ");
            }

            Console.Write("Enter Head of Department: ");
            string head = Console.ReadLine();

            Console.Write("Enter Extension Number: ");
            string extension = Console.ReadLine();

            departments.Add(new Department
            {
                DepartmentID = id,
                Name = name,
                Description = desc,
                FloorNumber = floor,
                HeadOfDepartment = head,
                ExtensionNumber = extension
            });

            Console.WriteLine(" Department added successfully.");
        }

        public void ShowDepartments()
        {
            if (departments.Count == 0)
            {
                Console.WriteLine(" No departments available.");
                return;
            }

            Console.WriteLine("\n Department List:");
            foreach (var d in departments)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"ID: {d.DepartmentID}");
                Console.WriteLine($"Name: {d.Name}");
                Console.WriteLine($"Description: {d.Description}");
                Console.WriteLine($"Floor: {d.FloorNumber}");
                Console.WriteLine($"Head: {d.HeadOfDepartment}");
                Console.WriteLine($"Extension: {d.ExtensionNumber}");
            }
        }


        public void UpdateDepartment()
        {
            Console.Write("Enter Department ID to update: ");
            string id = Console.ReadLine();

            var dept = departments.FirstOrDefault(d => d.DepartmentID == id);

            if (dept == null)
            {
                Console.WriteLine(" Department not found.");
                return;
            }

            Console.WriteLine(" Leave field empty to keep current value.");

            Console.Write($"Name ({dept.Name}): ");
            string name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name)) dept.Name = name;

            Console.Write($"Description ({dept.Description}): ");
            string desc = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(desc)) dept.Description = desc;

            Console.Write($"Floor ({dept.FloorNumber}): ");
            string floorInput = Console.ReadLine();
            if (int.TryParse(floorInput, out int floor)) dept.FloorNumber = floor;

            Console.Write($"Head of Department ({dept.HeadOfDepartment}): ");
            string head = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(head)) dept.HeadOfDepartment = head;

            Console.Write($"Extension ({dept.ExtensionNumber}): ");
            string ext = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(ext)) dept.ExtensionNumber = ext;

            Console.WriteLine(" Department updated successfully.");
        }






        public void DeleteDepartment()
        {
            Console.Write("Enter Department ID to delete: ");
            string id = Console.ReadLine();

            var dept = departments.FirstOrDefault(d => d.DepartmentID == id);

            if (dept == null)
            {
                Console.WriteLine(" Department not found.");
                return;
            }

            departments.Remove(dept);
            Console.WriteLine($"Department '{dept.Name}' deleted successfully.");
        }



        public void RunDepartmentMenu()
        {
            while (true)
            {
                Console.WriteLine("\n Department Management Menu:");
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2. Show Departments");
                Console.WriteLine("3. Update Department");
                Console.WriteLine("4. Delete Department");
                Console.WriteLine("5. Exit");

                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddDepartment(); break;
                    case "2": ShowDepartments(); break;
                    case "3": UpdateDepartment(); break;
                    case "4": DeleteDepartment(); break;
                    case "5": return;
                    default: Console.WriteLine(" Invalid option."); break;
                }
            }
        }




    }




}