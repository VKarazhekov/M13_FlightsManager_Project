using Flights_manager.Models.Passenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Reservation
{
    public class ReservationDetailsViewModel
    {
        public string Email { get; set; }
        public List<SinglePassengerViewModel> Passengers { get; set; }
    }
}
