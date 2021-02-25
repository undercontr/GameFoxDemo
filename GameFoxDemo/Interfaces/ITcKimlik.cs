using System;
using System.Collections.Generic;
using System.Text;

namespace GameFoxDemo.Interfaces
{
    interface ITcKimlik
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string YearOfBirth { get; set; }

        public void Validate();
    }
}
