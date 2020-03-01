using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Flight
{
    public class FlightListViewModel
    {
        public ICollection<SingleFlightViewModel> Flights { get; set; }
    }
}
