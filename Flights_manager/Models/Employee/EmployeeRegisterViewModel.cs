using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace Flights_manager.Models
{
    public class EmployeeRegisterViewModel
    {
        [Required]
        [MaxLength(15, ErrorMessage = "Username cannot be longer than 15 characters!")]
        public string Username { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password cannot be shorter than 8 characters!")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "First name cannot be longer than 15 characters!")]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Last name cannot be longer than 15 characters!")]
        public string Lastname { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Personal ID cannot be shorter than 8 numbers!")]
        [MaxLength(10, ErrorMessage = "Personal ID cannot be longer than 10 numbers!")]
        public string USN { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Address must be described more briefly.")]
        [MinLength(15, ErrorMessage = "Address must be described more thoroughly.")]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public string Role { get; set; }
    }
}
