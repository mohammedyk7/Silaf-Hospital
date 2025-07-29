using System;

namespace Silaf_Hospital.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;

        public Branch() { }

        public Branch(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
        }

        public static Branch CreateBranchFromInput()
        {
            Console.WriteLine("\n🏢 Create New Branch:");

            Console.Write("Enter Branch ID: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("❌ Invalid input. Enter a number for Branch ID: ");
            }

            Console.Write("Enter Branch Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Branch Location: ");
            string location = Console.ReadLine();

            return new Branch(id, name, location);
        }

        public void Display()
        {
            Console.WriteLine($"\n🏥 Branch Info:");
            Console.WriteLine($"ID       : {Id}");
            Console.WriteLine($"Name     : {Name}");
            Console.WriteLine($"Location : {Location}");
        }
    }
}
