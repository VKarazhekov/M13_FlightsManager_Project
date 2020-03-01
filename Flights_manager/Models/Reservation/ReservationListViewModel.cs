using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Reservation
{
    public class ReservationListViewModel
    {
        public ICollection<SingleReservationViewModel> Reservations { get; set; }
    }
}
