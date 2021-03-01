using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace GameFoxDemo
{
    public class Gamer : IGamer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long TcNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public List<IGames> GamesPuchased { get; set; }
    }
}
