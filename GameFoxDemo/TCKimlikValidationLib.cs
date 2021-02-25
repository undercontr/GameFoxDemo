using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using GameFoxDemo.Interfaces;

namespace GameFoxDemo
{
    public class TcKimlikValidationLib : ITcKimlik
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string YearOfBirth { get; set; }

        public void Validate()
        {
            Console.WriteLine($@"{TcNo} is validated.");
        }
    }
}
