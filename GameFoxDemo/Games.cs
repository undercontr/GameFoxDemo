﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameFoxDemo
{
    public class Games : IGames
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public DateTime DateOfRelease { get; set; }
    }
}
