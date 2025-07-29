using System;
using System.Collections.Generic;

namespace Silaf_Hospital.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<(int DoctorId, int ClinicId)> DoctorClinicAssignments = new List<(int, int)>();

        public static void AssignDoctorToClinic()
        {
            Console.Clear();
            Console.WriteLine(" Assign Doctor to Clinic\n");

            Console.Write("Enter Doctor ID: ");
            int doctorId;
            while (!int.TryParse(Console.ReadLine(), out doctorId))
            {
                Console.Write(" Invalid input. Enter a valid Doctor ID: ");
            }

            Console.Write("Enter Clinic ID: ");
            int clinicId;
            while (!int.TryParse(Console.ReadLine(), out clinicId))
            {
                Console.Write(" Invalid input. Enter a valid Clinic ID: ");
            }

            DoctorClinicAssignments.Add((doctorId, clinicId));

            Console.WriteLine($"\n Doctor {doctorId} assigned to Clinic {clinicId} successfully!");
            Console.WriteLine("Press Enter to return...");
            Console.ReadLine();
        }

        public static void ViewDoctorClinicAssignments()
        {
            Console.WriteLine("\n📋 Doctor-Clinic Assignments:");
            if (DoctorClinicAssignments.Count == 0)
            {
                Console.WriteLine("No assignments found.");
                return;
            }

            foreach (var pair in DoctorClinicAssignments)
            {
                Console.WriteLine($"Doctor ID: {pair.DoctorId} ⟶ Clinic ID: {pair.ClinicId}");
            }
        }
    }
}
