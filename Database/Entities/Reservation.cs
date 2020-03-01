using Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<Passenger> Passengers { get; set; }

    }
}
