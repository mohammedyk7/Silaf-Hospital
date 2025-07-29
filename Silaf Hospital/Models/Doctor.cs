using Silaf_Hospital.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silaf_Hospital.Models
{

    public class Doctor

    {
        public string DoctorID { get; set; }
        public string Specialization { get; set; }

        public int YearsOfExperience { get; set; }
        public double Salary { get; set; }
        public string Availability { get; set; }

        public string Branch { get; set; }
        public string Department { get; set; }

        public static List<Doctor> doctors = new List<Doctor>();


        public static void AddDoctor()
        {
            Doctor doctor = new Doctor();

            Console.Write("Enter Doctor ID: ");
            doctor.DoctorID = Console.ReadLine();

            Console.Write("Enter Specialization: ");
            doctor.Specialization = Console.ReadLine();

            int YearsExperience;
            Console.Write("Enter Years of Experience: ");
            while (!int.TryParse(Console.ReadLine(), out YearsExperience))
            {
                Console.Write("Invalid input. Try again: ");
            }
            doctor.YearsOfExperience = YearsExperience;

            int salary;
            Console.Write("Enter Salary: ");
            while (!int.TryParse(Console.ReadLine(), out salary))
            {
                Console.Write("Invalid input. Try again: ");
            }
            doctor.Salary = salary;

            Console.Write("Enter Availability: ");
            doctor.Availability = Console.ReadLine();

            doctors.Add(doctor);
            Console.WriteLine(" Doctor added successfully.");
        }


        public static void ShowAllDoctors()
        {
            if (doctors.Count == 0)
            {
                Console.WriteLine("❌ No doctors to display.");
                return;
            }

            Console.WriteLine("\nAll Doctors:");
            foreach (var d in doctors)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"ID: {d.DoctorID}");
                Console.WriteLine($"Specialization: {d.Specialization}");
                Console.WriteLine($"Experience: {d.YearsOfExperience} years");
                Console.WriteLine($"Salary: {d.Salary}");
                Console.WriteLine($"Availability: {d.Availability}");
            }



        }

        public static void DeleteDoctor()
        {
            if (doctors.Count == 0)
            {
                Console.WriteLine("❌ No doctors to delete.");
                return;
            }

            Console.Write("Enter Doctor ID to delete: ");
            string idToDelete = Console.ReadLine();

            Doctor doctorToRemove = doctors.Find(d => d.DoctorID == idToDelete);

            if (doctorToRemove != null)
            {
                doctors.Remove(doctorToRemove);
                Console.WriteLine($"Doctor with ID {idToDelete} deleted successfully.");
            }
            else
            {
                Console.WriteLine($" Doctor with ID {idToDelete} not found.");
            }
        }





        public static void UpdateDoctor()
        {
            if (doctors.Count == 0)
            {
                Console.WriteLine(" No doctors available to update.");
                return;
            }

            Console.Write("Enter Doctor ID to update: ");
            string idToUpdate = Console.ReadLine();

            Doctor doctor = doctors.Find(d => d.DoctorID == idToUpdate);

            if (doctor == null)
            {
                Console.WriteLine($"❌ Doctor with ID {idToUpdate} not found.");
                return;
            }

            Console.WriteLine(" Leave field empty if you don't want to change it.");

            Console.Write("Enter new Specialization: ");
            string newSpecialization = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newSpecialization))
                doctor.Specialization = newSpecialization;

            Console.Write("Enter new Years of Experience: ");
            string yearsInput = Console.ReadLine();
            if (int.TryParse(yearsInput, out int newYears))
                doctor.YearsOfExperience = newYears;

            Console.Write("Enter new Salary: ");
            string salaryInput = Console.ReadLine();
            if (int.TryParse(salaryInput, out int newSalary))
                doctor.Salary = newSalary;

            Console.Write("Enter new Availability: ");
            string newAvailability = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newAvailability))
                doctor.Availability = newAvailability;

            Console.WriteLine($" Doctor with ID {idToUpdate} updated successfully.");
        }

        public static void displayDoctorInterFacse()
        {
            while (true)
            {
                Console.WriteLine("\n Doctor Management Menu:");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. View All Doctors");
                Console.WriteLine("3. Update Doctor");
                Console.WriteLine("4. Delete Doctor");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddDoctor();
                        break;
                    case "2":
                        ShowAllDoctors();
                        break;
                    case "3":
                        UpdateDoctor();
                        break;
                    case "4":
                        DeleteDoctor();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine(" Invalid option.");
                        break;
                }



            }


        }
    }
}