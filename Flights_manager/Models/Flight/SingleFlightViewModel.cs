using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Flight
{
    public class SingleFlightViewModel
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime TakeOff { get; set; }
        public DateTime Landing { get; set; }
        public string TypePlane { get; set; }
        public int PlaneId { get; set; }
        public string PilotName { get; set; }
        public int AvailablePassengerSeats { get; set; }
        public int AvailableBusinessClassSeats { get; set; }
    }
}
