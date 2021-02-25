using System;
using System.Collections.Generic;
using System.Text;

namespace GameFoxDemo
{
    interface IGamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public List<IGames> GamesPuchased { get; set; }

    }
}
