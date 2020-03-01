using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Flight
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
