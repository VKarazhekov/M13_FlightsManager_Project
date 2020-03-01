﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Flights_manager.Models
{
    public class EmployeeLoginViewModel
    {   
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
