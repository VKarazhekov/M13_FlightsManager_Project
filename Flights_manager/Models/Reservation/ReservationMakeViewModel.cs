using Flights_manager.Models.Passenger;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Reservation
{
    public class ReservationMakeViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public List<SinglePassengerViewModel> Passengers { get; set; }
    }
}
