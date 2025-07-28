using System;
using System.Collections.Generic;
using System.Text;


namespace Silaf_Hospital.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!; // "Admin", "Doctor", "Patient", etc.
        public bool IsActive { get; set; } = true;

        // Parameterless constructor (required by EF Core)
        public User() { }

        // Optional constructor for easier object creation
        public User(string fullName, string email, string password, string role)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Role = role;
            IsActive = true;
        }
    }
}
