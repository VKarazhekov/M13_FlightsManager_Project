﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string USN { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get;  set; }
    }
}
