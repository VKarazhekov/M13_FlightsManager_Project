using Flights_manager.Models.Passenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Reservation
{
    public class SingleReservationViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<SinglePassengerViewModel> Passengers { get; set; }
    }
}
