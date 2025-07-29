using System;
using System.Collections.Generic;

namespace Silaf_Hospital.Models
{
    public class BranchDepartment
    {
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }

        public static List<BranchDepartment> AssignedDepartments = new List<BranchDepartment>();

        public static void AssignDepartmentToBranch()
        {
            Console.Clear();
            Console.WriteLine("🏢 Assign Department to Branch\n");

            Console.Write("Enter Branch ID: ");
            int branchId;
            while (!int.TryParse(Console.ReadLine(), out branchId))
            {
                Console.Write("❌ Invalid input. Enter a valid Branch ID: ");
            }

            Console.Write("Enter Department ID: ");
            int departmentId;
            while (!int.TryParse(Console.ReadLine(), out departmentId))
            {
                Console.Write("❌ Invalid input. Enter a valid Department ID: ");
            }

            BranchDepartment assignment = new BranchDepartment
            {
                BranchId = branchId,
                DepartmentId = departmentId
            };

            AssignedDepartments.Add(assignment);

            Console.WriteLine($"\n✅ Department {departmentId} assigned to Branch {branchId} successfully!");
            Console.WriteLine("Press Enter to return...");
            Console.ReadLine();
        }

        public static void ViewAssignments()
        {
            Console.WriteLine("\n📋 Assigned Departments to Branches:");
            if (AssignedDepartments.Count == 0)
            {
                Console.WriteLine("No assignments found.");
                return;
            }

            foreach (var assignment in AssignedDepartments)
            {
                Console.WriteLine($"Branch ID: {assignment.BranchId} ⟶ Department ID: {assignment.DepartmentId}");
            }
        }
    }
}
