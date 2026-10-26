using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSystem.Users
{
    internal class Patient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public Patient(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Patient Name: {Name} {Surname}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"");
        }
    }
}
