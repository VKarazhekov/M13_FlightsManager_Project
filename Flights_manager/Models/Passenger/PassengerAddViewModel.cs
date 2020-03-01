using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Passenger
{
    public class PassengerAddViewModel : SinglePassengerViewModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "First name cannot be shorter than 2 characters!")]
        [MaxLength(15, ErrorMessage = "First name cannot be longer than 15 characters!")]
        public new string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Surname cannot be shorter than 2 characters!")]
        [MaxLength(15, ErrorMessage = "Surname cannot be longer than 15 characters!")]
        public new string Surname { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last name cannot be shorter than 2 characters!")]
        [MaxLength(15, ErrorMessage = "Last name cannot be longer than 15 characters!")]
        public new string LastName { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Personal ID cannot be shorter than 8 numbers!")]
        [MaxLength(10, ErrorMessage = "Personal ID cannot be longer than 10 numbers!")]
        public new string USN { get; set; }

        [Required]
        [Phone]
        public new string PhoneNumber { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Nationality cannot be shorter than 4 characters!")]
        [MaxLength(12, ErrorMessage = "Nationality cannot be longer than 12 characters!")]
        public new string Nationality { get; set; }

        [Required]
        public new string TicketType { get; set; }

        [HiddenInput]
        public new int ReservationId { get; set; }
    }
}
