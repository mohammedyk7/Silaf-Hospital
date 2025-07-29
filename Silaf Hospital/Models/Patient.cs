using System;
using System.Collections.Generic;
using System.Text;

namespace Silaf_Hospital.Models
{
    public class Patient : User
    {
        public string PhoneNumber { get; set; } = null!;
        public ICollection<Booking>? Bookings { get; set; } //becsause patient can book many appointments 

        public Patient() { }

        public Patient(string fullName, string email, string password, string phoneNumber)
            : base(fullName, email, password, "Patient")
        {
            PhoneNumber = phoneNumber;
        }
    }
}





